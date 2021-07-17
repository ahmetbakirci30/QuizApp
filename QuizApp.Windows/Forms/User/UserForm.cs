using QuizApp.Shared.Entities.Quizzes;
using QuizApp.Shared.Managers.Database;
using QuizApp.Shared.Managers.Database.Interfaces;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuizApp.Windows
{
    public partial class UserForm : Form
    {
        private readonly Guid _userId;
        private readonly IDatabaseManager<Quiz> _quizDb;

        public UserForm(Guid userId)
        {
            _userId = userId;
            _quizDb = new DatabaseManager<Quiz>();

            InitializeComponent();
        }

        private async void UserForm_Load(object sender, EventArgs e)
        {
            foreach (var quiz in ((await _quizDb.GetAsync()) ?? Array.Empty<Quiz>()).OrderBy(_ => Guid.NewGuid()))
                lstQuizzes.Items.Add(new ListViewItem { Text = quiz.Title, Tag = quiz.Id });
        }

        private void BtnStartQuiz_Click(object sender, EventArgs e)
        {
            if (lstQuizzes.SelectedItems == null || lstQuizzes.SelectedItems.Count <= 0 || lstQuizzes.SelectedItems[0] == null)
            {
                MessageBox.Show("Please select a quiz first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            new UserQuizForm(_userId, (Guid)lstQuizzes.SelectedItems[0].Tag).Show();
            Hide();
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
            => Application.Exit();
    }
}