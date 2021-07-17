using QuizApp.Shared.Entities.Quizzes;
using QuizApp.Shared.Managers.Database;
using QuizApp.Shared.Managers.Database.Interfaces;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuizApp.Windows.Forms
{
    public partial class QuizForm : Form
    {
        private readonly IDatabaseManager<Quiz> _quizDb;
        private readonly IDatabaseManager<Question> _questionDb;
        private readonly IDatabaseManager<Answer> _answerDb;
        private readonly Guid? _quizId;
        private Quiz _quiz;

        public QuizForm(Guid? quizId = null)
        {
            _quizDb = new DatabaseManager<Quiz>();
            _questionDb = new DatabaseManager<Question>();
            _answerDb = new DatabaseManager<Answer>();
            _quizId = quizId;

            InitializeComponent();
        }

        private async void QuizForm_Load(object sender, EventArgs e)
        {
            if (_quizId.HasValue && (!_quizId.Equals(Guid.Empty)))
                _quiz = await _quizDb.GetAsync(_quizId.Value);

            _quiz ??= new Quiz();
            txtQuizTitle.Text = _quiz.Title;

            RefreshQuestionList();
        }

        private async void RefreshQuestionList()
        {
            lstQuestions.Clear();

            foreach (var question in ((await _questionDb.GetAsync()) ?? Array.Empty<Question>()).Where(question => question.QuizId.Equals(_quiz.Id)))
                lstQuestions.Items.Add(new ListViewItem { Text = question.Text, Tag = question.Id });
        }

        private void BtnAddNewQuestion_Click(object sender, EventArgs e)
            => OpenQuestionForm();

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            var quizTitle = txtQuizTitle.Text;

            if (string.IsNullOrWhiteSpace(quizTitle))
            {
                MessageBox.Show("Please enter quiz title first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _quiz.Title = quizTitle;
            await _quizDb.SaveAsync(_quiz);
            Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (lstQuestions.SelectedItems == null || lstQuestions.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please select a question first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenQuestionForm((Guid)lstQuestions.SelectedItems[0].Tag);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (lstQuestions.SelectedItems == null || lstQuestions.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please select a question first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DeleteQuestion((Guid)lstQuestions.SelectedItems[0].Tag);
        }

        private async void DeleteQuestion(Guid questionId)
        {
            foreach (var answer in (await _answerDb.GetAsync() ?? Array.Empty<Answer>()).Where(answer => answer.QuestionId == questionId))
                await _answerDb.DeleteAsync(answer.Id);

            await _questionDb.DeleteAsync(questionId);
            RefreshQuestionList();
        }

        private void OpenQuestionForm(Guid? id = null)
        {
            new QuestionForm(_quiz.Id, id).ShowDialog();
            RefreshQuestionList();
        }
    }
}