using System;
using System.Windows.Forms;

namespace LogReg
{
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        public void LoginClicked(object sender, EventArgs e)
        {
            Db database = new Db();
            if (username.Text == string.Empty || username.Text == null || password.Text == string.Empty || password.Text == null)
            {
                MessageBox.Show("Beviteli hiba!", "Nem megfelelő a beviteli formátum", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Db.UserStatus userStatus = database.UsersExists(username.Text, password.Text);
            switch (userStatus)
            {
                case Db.UserStatus.UNE:
                    MessageBox.Show("Nem létezik ilyen felhasználó!", "Bejelentkezés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case Db.UserStatus.WP:
                    MessageBox.Show("Rossz jelszó!", "Bejelentkezés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case Db.UserStatus.UE:
                    MessageBox.Show("Sikeres bejelentkezés", "Bejelentkezés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Visible = false;
                    new UserList(this).ShowDialog();
                    break;
            }
        }

        public void RegisterClicked(object sender, EventArgs e)
        {
            Visible = false;
            new RegisterPanel(this).ShowDialog();
        }
    }
}
