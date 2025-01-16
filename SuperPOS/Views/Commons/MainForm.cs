using FontAwesome.Sharp;
using SuperPOS.Views.Users;
using System.Windows.Forms;

namespace SuperPOS.Views
{
    public partial class MainForm : Form
    {
        private Form activeChildForm;
        private Panel activePanelSubMenu;
        private LoginForm loginForm;

        public MainForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private void OpenSubMenu(Panel panelSubMenu)
        {
            if (panelSubMenu != null)
            {
                activePanelSubMenu = panelSubMenu;
                activePanelSubMenu.Visible = true;
            }
        }

        private void OpenChildForm(Form formChild, string title, IconChar icon)
        {
            if (activeChildForm != null)
            {
                activeChildForm.Close();
                activeChildForm = null;
            }
            if (formChild != null)
            {
                activeChildForm = formChild;
                activeChildForm.TopLevel = false;
                activeChildForm.FormBorderStyle = FormBorderStyle.None;
                activeChildForm.Dock = DockStyle.Fill;
                panelMain.Controls.Add(activeChildForm);
                panelMain.Tag = activeChildForm;
                activeChildForm.BringToFront();
                activeChildForm.Show();
            }
            if (!string.IsNullOrEmpty(title))
            {
                iconButtonTitle.Text = title;
            }
            iconButtonTitle.IconChar = icon;
        }

        private void Reset(Panel activePanel)
        {
            if (activeChildForm != null)
            {
                activeChildForm.Close();
                activeChildForm = null;
            }
            iconButtonTitle.Text = "Home";
            iconButtonTitle.IconChar = IconChar.House;
            if (activePanelSubMenu != null && activePanelSubMenu != activePanel)
            {
                activePanelSubMenu.Visible = false;
                activePanelSubMenu = null;
            }
        }

        private void iconButtonTransaction_Click(object sender, System.EventArgs e)
        {
            Reset(panelTransaction);
            OpenSubMenu(panelTransaction);
        }

        private void iconButtonMasterData_Click(object sender, System.EventArgs e)
        {
            Reset(panelMasterData);
            OpenSubMenu(panelMasterData);
        }

        private void iconButtonHome_Click(object sender, System.EventArgs e)
        {
            Reset(null);
            OpenSubMenu(null);
        }

        private void iconButtonSettings_Click(object sender, System.EventArgs e)
        {
            Reset(null);
            OpenSubMenu(null);
        }

        private void iconButtonUsers_Click(object sender, System.EventArgs e)
        {
            Reset(panelMasterData);
            OpenChildForm(new UserForm(), iconButtonUsers.Text, iconButtonUsers.IconChar);
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            if (Program.CurrentUser != null && Program.CurrentUser.IsAdmin)
            {
                iconButtonMasterData.Visible = true;
            }
            else
            {
                iconButtonMasterData.Visible = false;
            }
        }

        private void iconButtonLogout_Click(object sender, System.EventArgs e)
        {
            Program.CurrentUser = null;
            loginForm.Show();
            Close();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
