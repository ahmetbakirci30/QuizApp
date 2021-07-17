using QuizApp.Shared.Entities.Users;
using QuizApp.Shared.Services.Users;
using System;
using System.Windows.Forms;

namespace QuizApp.Windows
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
            => InitializeComponent();

        private async void BtnRegister_Click(object sender, EventArgs e)
        {
            if (!txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                MessageBox.Show("Password and confirm password do not match!", "Password Confirm Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = new ApplicationUser
            {
                FullName = txtFullName.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Role = UserRole.User
            };

            var (succeeded, message) = await new UserService().AddAsync(user);

            MessageBox.Show(message, "Registration Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (succeeded)
            {
                new UserForm(user.Id).Show();
                Hide();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            Hide();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
            => Application.Exit();
    }
}