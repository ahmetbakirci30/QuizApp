using QuizApp.Shared.Entities.Users;
using QuizApp.Shared.Services.Users;
using System;
using System.Windows.Forms;

namespace QuizApp.Windows
{
    public partial class LoginForm : Form
    {
        public LoginForm()
            => InitializeComponent();

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            var user = await new UserService().GetAsync(txtUsername.Text, txtPassword.Text);

            if (user == null)
            {
                MessageBox.Show("Invalid Login Attempt!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form form = user.Role.Equals(UserRole.User) ? new UserForm(user.Id) : new AdministratorForm(user.Id);
            form.Show();
            Hide();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            Hide();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
            => Application.Exit();
    }
}