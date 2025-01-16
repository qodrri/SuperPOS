using SuperPOS.Core.Helpers;
using SuperPOS.Models;
using System;
using System.Windows.Forms;

namespace SuperPOS.Views.Users
{
    public partial class UserEntryForm : Form
    {
        public User NewUser { get; set; }
        public User UpdateUser { get; set; }

        private bool _isPasswordVisible = false;
        private bool _isRepeatPasswordVisible = false;

        public UserEntryForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (UpdateUser != null)
                {
                    UpdateUser.Username = textBoxUsername.Text;
                    UpdateUser.Firstname = textBoxFirstname.Text;
                    UpdateUser.Lastname = textBoxLastname.Text;
                    UpdateUser.Email = textBoxEmail.Text;
                    UpdateUser.Phone = textBoxPhone.Text;
                    UpdateUser.IsAdmin = checkBoxIsAdmin.Checked;
                    if (!string.IsNullOrEmpty(textBoxPassword.Text) && !string.IsNullOrEmpty(textBoxRepeatPassword.Text) && textBoxPassword.Text == textBoxRepeatPassword.Text)
                    {
                        UpdateUser.Password = PasswordHelper.HashPassword(textBoxPassword.Text);
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(textBoxPassword.Text) || string.IsNullOrEmpty(textBoxRepeatPassword.Text) || textBoxPassword.Text != textBoxRepeatPassword.Text)
                    {
                        MessageBox.Show("Password dan Ulangi Password harus diisi dan sama", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    NewUser = new User
                    {
                        Username = textBoxUsername.Text,
                        Firstname = textBoxFirstname.Text,
                        Lastname = textBoxLastname.Text,
                        Email = textBoxEmail.Text,
                        Phone = textBoxPhone.Text,
                        IsAdmin = checkBoxIsAdmin.Checked,
                        Password = PasswordHelper.HashPassword(textBoxPassword.Text)
                    };
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyimpan data user: {ex.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconButtonPasswordVisibility_Click(object sender, EventArgs e)
        {
            _isPasswordVisible = !_isPasswordVisible;
            if (_isPasswordVisible)
            {
                textBoxPassword.PasswordChar = '\0';
                iconButtonPasswordVisibility.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
                iconButtonPasswordVisibility.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void iconButtonRepeatPasswordVisibility_Click(object sender, EventArgs e)
        {
            _isRepeatPasswordVisible = !_isRepeatPasswordVisible;
            if (_isRepeatPasswordVisible)
            {
                textBoxRepeatPassword.PasswordChar = '\0';
                iconButtonRepeatPasswordVisibility.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                textBoxRepeatPassword.PasswordChar = '*';
                iconButtonRepeatPasswordVisibility.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void UserEntryForm_Load(object sender, EventArgs e)
        {
            if (UpdateUser != null)
            {
                textBoxUsername.Text = UpdateUser.Username;
                textBoxFirstname.Text = UpdateUser.Firstname;
                textBoxLastname.Text = UpdateUser.Lastname;
                textBoxEmail.Text = UpdateUser.Email;
                textBoxPhone.Text = UpdateUser.Phone;
                checkBoxIsAdmin.Checked = UpdateUser.IsAdmin;
            }
        }
    }
}
