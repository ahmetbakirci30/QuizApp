using QuizApp.Shared.Entities.Quizzes;
using QuizApp.Shared.Entities.Users;
using QuizApp.Shared.Managers.Database;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuizApp.Windows
{
    public partial class ScoreForm : Form
    {
        public ScoreForm()
            => InitializeComponent();

        private async void ScoreForm_Load(object sender, EventArgs e)
        {
            var users = (await new DatabaseManager<ApplicationUser>().GetAsync()) ?? Array.Empty<ApplicationUser>();

            foreach (var score in (await new DatabaseManager<Score>().GetAsync()) ?? Array.Empty<Score>())
            {
                score.User = users.FirstOrDefault(user => user.Id == score.UserId);

                lstScores.Items.Add(new ListViewItem { Text = $"{score.User.FullName}: {score.Percentage}" });
            }
        }
    }
}