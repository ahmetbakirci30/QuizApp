using QuizApp.Shared.Entities.Base;
using QuizApp.Shared.Entities.Users;
using System;

namespace QuizApp.Shared.Entities.Quizzes
{
    public class Score : EntityBase
    {
        public int Percentage { get; set; }

        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}