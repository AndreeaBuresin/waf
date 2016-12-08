using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VacationWindowsFormsApplication
{
    public partial class startPage : Form
    {
        public startPage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Exit(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void webSite(object sender, EventArgs e)
        {

        }

        private void createUser(object sender, EventArgs e)
        {
            CreateUserForm frm = new CreateUserForm();
            frm.Show();
        }

        private void updateUserPage(object sender, EventArgs e)
        {
            UpdateUserForm frm = new UpdateUserForm();
            frm.Show();
        }

        private void viewClientForm(object sender, EventArgs e)
        {
            ClientForm frm = new ClientForm();
            frm.Show();
        }
    }
}
