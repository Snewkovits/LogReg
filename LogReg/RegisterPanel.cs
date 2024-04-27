using System;
using System.Windows.Forms;

namespace LogReg
{
    public partial class RegisterPanel : Form
    {
        Form mainForm;
        public RegisterPanel(Form form)
        {
            InitializeComponent();
            mainForm = form;
        }

        public void BackClicked(object sender, EventArgs e)
        {
            Close();
        }

        private void RegisterClicked(object sender, EventArgs e)
        {
            Db database = new Db();
            if (password.Text.Trim() != passwordAgain.Text.Trim())
            {
                MessageBox.Show($"A jelszavak nem egyeznek!", "Regisztrálás", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!database.CreateUser(username.Text, email.Text, password.Text.Trim()))
            {
                MessageBox.Show("Nem megfelelő formátum!", "Regisztrálás", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Sikeres regisztrálás!", "Regisztrálás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void RegisterPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Visible = true;
        }
    }
}
