using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class SignUP : Form
    {
        public SignUP()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                string Username = txtUserName.Text;
                string Password = txtPassword.Text;
                

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-EQA9CU4 ; database =library;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = " insert into logintable (Username,Password) values ('" + Username + "','" + Password + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Hii ! Your are In.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Clear();
                txtPassword.Clear();
                

            }
            else
            {
                MessageBox.Show("Empty fields NOT allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle the password visibility in the TextBox
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false; // Show password characters
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true; // Hide password characters
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
