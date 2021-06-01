using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Car_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Login_Load(object sender, EventArgs e)
        {

        }

        

        private void lblRegister_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btnLogin1_Click(object sender, EventArgs e)
        {
            //exporting data from the database in order to login if it doesnt exit it wont loging
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + txtUsername_log1.Text + "' and password= '" + txtPassword_log1.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                new Vehicle().Show();
                this.Hide();
            }
            else
            {
                //this is an error message that pops up if the user enter incorrect password or username and clears the textboxes
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword_log1.Text = "";
                txtUsername_log1.Text = "";
                txtUsername_log1.Focus();
            }
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            // this will clear/reset the textboxes
            txtUsername_log1.Text = "";
            txtPassword_log1.Text = "";
            txtUsername_log1.Focus();
        }

        

        private void lblRegister1_Click(object sender, EventArgs e)
        {
            // navigating to the register  window
            new Form1().Show();
            this.Hide();
        }

        private void chkShowpass_log1_CheckedChanged(object sender, EventArgs e)
        {
            // this is to show or hide password
            if (chkShowpass_log1.Checked)
            {
                txtPassword_log1.PasswordChar = '\0';

            }
            else
            {
                txtPassword_log1.PasswordChar = '•';

            }
        }
    }
}
