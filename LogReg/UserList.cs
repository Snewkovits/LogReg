using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogReg
{
    public partial class UserList : Form
    {
        Form mainForm;
        public UserList(Form form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            foreach (User user in new Db().GetAllUser())
            {
                UserListBox.Items.Add(user);
            }
        }

        private void UserList_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Visible = true;
        }
    }
}
