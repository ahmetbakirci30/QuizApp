using QuizApp.Shared.Entities.Base;

namespace QuizApp.Shared.Entities.Users
{
    public class ApplicationUser : EntityBase
    {
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }
}