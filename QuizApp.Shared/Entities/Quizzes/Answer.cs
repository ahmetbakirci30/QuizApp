using QuizApp.Shared.Entities.Base;
using System;

namespace QuizApp.Shared.Entities.Quizzes
{
    public class Answer : EntityBase
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; } = false;

        public Guid QuestionId { get; set; }
        public Question Question { get; set; }
    }
}