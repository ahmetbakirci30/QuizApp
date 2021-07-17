using QuizApp.Shared.Entities.Quizzes;
using QuizApp.Shared.Managers.Database;
using QuizApp.Shared.Managers.Database.Interfaces;
using QuizApp.Windows.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuizApp.Windows
{
    public partial class AdministratorForm : Form
    {
        private readonly Guid _userId;
        private readonly IDatabaseManager<Quiz> _quizDb;
        private readonly IDatabaseManager<Question> _questionDb;
        private readonly IDatabaseManager<Answer> _answerDb;

        public AdministratorForm(Guid userId)
        {
            _userId = userId;
            _quizDb = new DatabaseManager<Quiz>();
            _questionDb = new DatabaseManager<Question>();
            _answerDb = new DatabaseManager<Answer>();

            InitializeComponent();
        }

        private void AdministratorForm_Load(object sender, EventArgs e)
            => RefreshQuizList();

        private void BtnAddNewQuiz_Click(object sender, EventArgs e)
            => OpenQuizForm();

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (lstQuizzes.SelectedItems == null || lstQuizzes.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please select a quiz first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenQuizForm((Guid)lstQuizzes.SelectedItems[0].Tag);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (lstQuizzes.SelectedItems == null || lstQuizzes.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please select a quiz first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DeleteQuiz((Guid)lstQuizzes.SelectedItems[0].Tag);
        }

        private async void DeleteQuiz(Guid quizId)
        {
            foreach (var question in (await _questionDb.GetAsync() ?? Array.Empty<Question>()).Where(question => question.QuizId == quizId))
            {
                foreach (var answer in (await _answerDb.GetAsync() ?? Array.Empty<Answer>()).Where(answer => answer.QuestionId == question.Id))
                    await _answerDb.DeleteAsync(answer.Id);

                await _questionDb.DeleteAsync(question.Id);
            }

            await _quizDb.DeleteAsync(quizId);
            RefreshQuizList();
        }

        private void OpenQuizForm(Guid? id = null)
        {
            new QuizForm(id).ShowDialog();
            RefreshQuizList();
        }

        private async void RefreshQuizList()
        {
            lstQuizzes.Items.Clear();

            foreach (var quiz in (await _quizDb.GetAsync()) ?? Array.Empty<Quiz>())
                lstQuizzes.Items.Add(new ListViewItem { Text = quiz.Title, Tag = quiz.Id });
        }

        private void BtnMemberLogin_Click(object sender, EventArgs e)
        {
            new UserForm(_userId).Show();
            Hide();
        }

        private void BtnScore_Click(object sender, EventArgs e)
        {
            new ScoreForm().ShowDialog();
        }

        private void AdministratorForm_FormClosed(object sender, FormClosedEventArgs e)
            => Application.Exit();
    }
}