using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("confirm?" , "Alert" , MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) 
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            txtEnrollmentNumber.Clear();
            txtDepartment.Clear();
            txtStudentContact.Clear();  
            txtStudentSemester.Clear();
        

            
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            string Name = txtStudentName.Text;
            string enroll = txtEnrollmentNumber.Text;
            string department = txtDepartment.Text;
            string sem = txtStudentSemester.Text;
            Int64 mobile = Int64.Parse(txtStudentContact.Text);
            

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-EQA9CU4 ; database =library;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = " insert into newStudent (sName,sEnroll,sDep,sSem,sMobile) values ('" + Name + "','" + enroll + "','" + department + "','" + sem + "','" + mobile + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
