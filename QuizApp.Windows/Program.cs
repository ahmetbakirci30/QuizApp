using QuizApp.Shared.Entities.Users;
using QuizApp.Shared.Services.Users;
using System;
using System.Windows.Forms;

namespace QuizApp.Windows
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            new UserService().AddAsync(new ApplicationUser
            {
                FullName = "Ahmet Bakirci",
                Username = "admin",
                Password = "123",
                Role = UserRole.Administrator
            }).Wait();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}