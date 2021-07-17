using QuizApp.Shared.Entities.Base;

namespace QuizApp.Shared.Entities.Quizzes
{
    public class Quiz : EntityBase
    {
        public string Title { get; set; }

        public Question[] Questions { get; set; }
    }
}