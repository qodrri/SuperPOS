using System;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Microsoft.Extensions.DependencyInjection;
using SuperPOS.Core.Helpers;
using SuperPOS.Repositories.UserRepository;

namespace SuperPOS.Views
{
    public partial class LoginForm : Form
    {
        private bool isPasswordVisible = false;
        private readonly IUserRepository _userRepository;
        public LoginForm()
        {
            InitializeComponent();
            _userRepository = Program.ServiceProvider.GetService<IUserRepository>();
        }

        private void iconButtonShowHidePassword_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            if (isPasswordVisible)
            {
                iconButtonShowHidePassword.IconChar = IconChar.EyeSlash;
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                iconButtonShowHidePassword.IconChar = IconChar.Eye;
                textBoxPassword.PasswordChar = '*';
            }
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxUsername.Text) && !string.IsNullOrEmpty(textBoxPassword.Text))
            {
                try
                {
                    // Cek apakah user dengan username dan password tersebut ada
                    var user = await _userRepository.GetByUsernameAsync(textBoxUsername.Text);
                    if (user != null)
                    {
                        if (PasswordHelper.VerifyPassword(textBoxPassword.Text, user.Password))
                        {
                            textBoxUsername.Text = "";
                            textBoxPassword.Text = "";
                            Program.CurrentUser = user;
                            MainForm mainForm = new MainForm(this);
                            mainForm.Show();
                            textBoxUsername.Focus();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Password salah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username tidak ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal login: {ex.ToString()}", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Username dan Password harus diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
