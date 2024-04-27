using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogReg_Minimum
{
    public partial class Regisztrálás : Form
    {
        public Regisztrálás()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User(1, felhasznalonev.Text, email.Text, jelszo.Text);
            Adatbazis adatbazis = new Adatbazis();
            adatbazis.AddUser(user);
            MessageBox.Show("Sikeres regisztrálás!");
            Close();
        }
    }
}
