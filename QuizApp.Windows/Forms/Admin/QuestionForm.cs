using QuizApp.Shared.Entities.Quizzes;
using QuizApp.Shared.Managers.Database;
using QuizApp.Shared.Managers.Database.Interfaces;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuizApp.Windows.Forms
{
    public partial class QuestionForm : Form
    {
        private readonly IDatabaseManager<Question> _questionDb;
        private readonly IDatabaseManager<Answer> _answerDb;
        private readonly Guid _quizId;
        private readonly Guid? _questionId;
        private Question _question;

        public QuestionForm(Guid quizId, Guid? questionId = null)
        {
            _questionDb = new DatabaseManager<Question>();
            _answerDb = new DatabaseManager<Answer>();
            _quizId = quizId;
            _questionId = questionId;

            InitializeComponent();
        }

        private async void QuestionForm_Load(object sender, EventArgs e)
        {
            if (_questionId.HasValue && (!_questionId.Equals(Guid.Empty)))
                _question = await _questionDb.GetAsync(_questionId.Value);

            _question ??= new Question { QuizId = _quizId };
            txtQuestion.Text = _question.Text;

            RefreshAnswerList();
        }

        private async void RefreshAnswerList()
        {
            lstAnswers.Clear();

            foreach (var answer in ((await _answerDb.GetAsync()) ?? Array.Empty<Answer>()).Where(answer => answer.QuestionId.Equals(_question.Id)))
                lstAnswers.Items.Add(new ListViewItem { Text = answer.Text, Tag = answer.Id });
        }

        private void BtnAddAnswer_Click(object sender, EventArgs e)
            => OpenAnswerForm();

        private void BtnEditAnswer_Click(object sender, EventArgs e)
        {
            if (lstAnswers.SelectedItems == null || lstAnswers.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please select a answer first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenAnswerForm((Guid)lstAnswers.SelectedItems[0].Tag);
        }

        private void OpenAnswerForm(Guid? answerId = null)
        {
            new AnswerForm(_question.Id, answerId).ShowDialog();
            RefreshAnswerList();
        }

        private async void BtnDeleteAnswer_Click(object sender, EventArgs e)
        {
            if (lstAnswers.SelectedItems == null || lstAnswers.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please select a answer first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await _answerDb.DeleteAsync((Guid)lstAnswers.SelectedItems[0].Tag);
            RefreshAnswerList();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            var questionText = txtQuestion.Text;

            if (string.IsNullOrWhiteSpace(questionText))
            {
                MessageBox.Show("Please enter question text first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var answers = ((await _answerDb.GetAsync()) ?? Array.Empty<Answer>()).Where(answer => answer.QuestionId.Equals(_question.Id));

            if (answers == null || answers.Count() != 4)
            {
                MessageBox.Show("Please add 4 choices for each question!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (answers.Count(answer => answer.IsCorrect == true) != 1)
            {
                MessageBox.Show("Each question must have one correct answer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _question.Text = questionText;
            await _questionDb.SaveAsync(_question);
            Close();
        }
    }
}