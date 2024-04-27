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
    public partial class OsszesFelhasznalo : Form
    {
        public OsszesFelhasznalo()
        {
            InitializeComponent();
        }

        private void OsszesFelhasznalo_Load(object sender, EventArgs e)
        {
            Adatbazis adatbazis = new Adatbazis();
            List<User> users = adatbazis.GetAllUser();
            foreach (User user in users)
            {
                listBox1.Items.Add(user);
            }
        }
    }
}
