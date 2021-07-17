using QuizApp.Shared.Entities.Quizzes;
using QuizApp.Shared.Managers.Database;
using QuizApp.Shared.Managers.Database.Interfaces;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuizApp.Windows
{
    public partial class UserQuizForm : Form
    {
        private readonly Guid _userId;
        private readonly Guid _quizId;
        private readonly IDatabaseManager<Question> _questionDb;
        private readonly IDatabaseManager<Answer> _answerDb;
        private readonly IDatabaseManager<Score> _scoreDb;
        private Question[] _questions;
        private Answer[] _answers;
        private int _questionNumber;

        public UserQuizForm(Guid userId, Guid quizId)
        {
            _userId = userId;
            _quizId = quizId;
            _questionDb = new DatabaseManager<Question>();
            _answerDb = new DatabaseManager<Answer>();
            _scoreDb = new DatabaseManager<Score>();

            InitializeComponent();
        }

        private async void UserQuizForm_Load(object sender, EventArgs e)
        {
            _questions = ((await _questionDb.GetAsync()) ?? Array.Empty<Question>()).Where(question => question.QuizId == _quizId).ToArray();
            _answers = (await _answerDb.GetAsync()) ?? Array.Empty<Answer>();

            if (!_questions.Any())
            {
                MessageBox.Show("This quiz is empty, does not contain any questions, try another quiz!");
                OpenUserForm();
                return;
            }

            ShowQuestion(_questions[_questionNumber]);
        }

        private void ShowQuestion(Question question)
        {
            lblQuestion.Text = question.Text;

            int y = 0;
            pnlAnswers.Controls.Clear();
            foreach (var answer in _answers.Where(answer => answer.QuestionId == question.Id))
                pnlAnswers.Controls.Add(new RadioButton { Text = answer.Text, Tag = answer.IsCorrect, Location = new Point(40, y += 55), AutoSize = true });
        }

        private void BtnCheckAnswer_Click(object sender, EventArgs e)
        {
            foreach (var control in pnlAnswers.Controls)
            {
                var option = (RadioButton)control;

                if (option.Checked)
                {
                    int score;

                    if ((bool)option.Tag)
                    {
                        score = (_questionNumber + 1) * 100 / _questions.Length;

                        if (_questionNumber < (_questions.Length - 1))
                        {
                            MessageBox.Show($"Congratulations, the answer is correct, go to the next question!\nYour Score: {score}");
                            ShowQuestion(_questions[++_questionNumber]);
                        }
                        else
                        {
                            FinishQuiz($"Congratulations you won!\nYour Score: {score}", score);
                        }
                    }
                    else
                    {
                        score = _questionNumber * 100 / _questions.Length;
                        FinishQuiz($"Unfortunately the answer is wrong, I wish you better luck next time!\nYour Score: {score}", score);
                    }

                    return;
                }
            }

            MessageBox.Show("please choose one of the options first!");
        }

        private async void FinishQuiz(string message, int score)
        {
            MessageBox.Show(message);
            await _scoreDb.SaveAsync(new Score { Percentage = score, UserId = _userId });
            OpenUserForm();
        }

        private void OpenUserForm()
        {
            new UserForm(_userId).Show();
            Hide();
        }

        private void UserQuizForm_FormClosed(object sender, FormClosedEventArgs e)
            => Application.Exit();
    }
}