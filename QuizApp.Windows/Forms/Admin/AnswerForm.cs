using QuizApp.Shared.Entities.Quizzes;
using QuizApp.Shared.Managers.Database;
using QuizApp.Shared.Managers.Database.Interfaces;
using System;
using System.Windows.Forms;

namespace QuizApp.Windows.Forms
{
    public partial class AnswerForm : Form
    {
        private readonly IDatabaseManager<Answer> _answerDb;
        private readonly Guid _questionId;
        private readonly Guid? _answerId;
        private Answer _answer;

        public AnswerForm(Guid questionId, Guid? answerId = null)
        {
            _answerDb = new DatabaseManager<Answer>();
            _questionId = questionId;
            _answerId = answerId;

            InitializeComponent();
        }

        private async void AnswerForm_Load(object sender, EventArgs e)
        {
            if (_answerId.HasValue && (!_answerId.Equals(Guid.Empty)))
                _answer = await _answerDb.GetAsync(_answerId.Value);

            _answer ??= new Answer { QuestionId = _questionId };

            txtAnswer.Text = _answer.Text;
            checkBoxCorrectAnswer.Checked = _answer.IsCorrect;
        }

        private async void BtnSaveAnswer_Click(object sender, EventArgs e)
        {
            var answerText = txtAnswer.Text;

            if (string.IsNullOrWhiteSpace(answerText))
            {
                MessageBox.Show("Please enter answer text first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _answer.Text = answerText;
            _answer.IsCorrect = checkBoxCorrectAnswer.Checked;
            await _answerDb.SaveAsync(_answer);
            Close();
        }
    }
}