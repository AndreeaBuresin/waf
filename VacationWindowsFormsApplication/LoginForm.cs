using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace VacationWindowsFormsApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void goStartPage(object sender, EventArgs e)
        {
            this.Hide();
            startPage frm = new startPage();
            frm.Show();
        }

        private void exitApplication(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkUser(object sender, EventArgs e)
        {

        }

        private void checkPassword(object sender, EventArgs e)
        {

        }
    }
}
