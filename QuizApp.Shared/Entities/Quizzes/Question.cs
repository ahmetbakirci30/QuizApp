using QuizApp.Shared.Entities.Base;
using System;

namespace QuizApp.Shared.Entities.Quizzes
{
    public class Question : EntityBase
    {
        public string Text { get; set; }

        public Guid QuizId { get; set; }
        public Quiz Quiz { get; set; }

        public Answer[] Answers { get; set; }
    }
}