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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void belepesGomb_Click(object sender, EventArgs e)
        {
            Adatbazis adatbazis = new Adatbazis();
            List<User> users = adatbazis.GetAllUser();
            foreach (User user in users )
            {
                if (felhasznalonev.Text == user.getUsername() && jelszo.Text == user.getPassword())
                {
                    MessageBox.Show("Sikeres bejelentkezés!");
                    new OsszesFelhasznalo().Show();
                    return;
                }
            }
            MessageBox.Show("Sikertelen bejelentkezés!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Regisztrálás().Show();
        }
    }
}
