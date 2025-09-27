using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class IssueBooks : Form
    {
        private int Count;

        public IssueBooks()
        {
            InitializeComponent();
        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-EQA9CU4 ; database =library;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            
            cmd = new SqlCommand("select bName from newBook",con);
            SqlDataReader sdr = cmd.ExecuteReader();
            
            while(sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    comboBox1.Items.Add(sdr.GetString(i));
                } 
            }
            sdr.Close();
            con.Close();
        }

        private void btsSearchStudent_Click(object sender, EventArgs e)
        {
            if (txtEnterEnrollmentNumber.Text != "")
            {
                string eid = txtEnterEnrollmentNumber.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-EQA9CU4 ; database =library;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " select * from newStudent where sEnroll = '" + eid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                //----------------------------------------------------------------------------------------------------------
                // code to count how many book has been issued on this enrollment number
                cmd.CommandText = "select count (std_enroll) from IRbook where std_enroll = '" + eid + "' and book_return_date is null";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);

                Count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
                //----------------------------------------------------------------------------------------------------------



                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtStudentName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtDepartment.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtStudentSem.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtStudentCon.Text = ds.Tables[0].Rows[0][5].ToString();
                }
                else
                {
                    txtStudentName.Clear();
                    txtDepartment.Clear();
                    txtStudentSem.Clear();
                    txtStudentCon.Clear();
                    MessageBox.Show("Invalid Enrollment Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (txtStudentName.Text != "")
            {
                if (comboBox1.SelectedIndex != -1 && Count <=2)
                {
                    string Enroll = txtEnterEnrollmentNumber.Text;
                    string Name = txtStudentName.Text;
                    string Dep = txtDepartment.Text;
                    string Sem = txtStudentSem.Text;
                    Int64 Con = Int64.Parse(txtStudentCon.Text);
                    string BookName = comboBox1.Text;
                    DateOnly IssuDate = DateOnly.Parse(dateTimePicker1.Text);

                    string eid = txtEnterEnrollmentNumber.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-EQA9CU4 ; database =library;integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();

                    cmd.CommandText = " insert into IRbook (std_enroll,std_name,std_dep,std_sem,std_contact,book_name,book_issue_data) values ('"+Enroll+ "','"+Name+ "','"+Dep+"','"+Sem+"','"+Con+"','"+BookName+"','"+IssuDate+"')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show ("Book Issued.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Selecte Book OR Maximum Number of Book Has Been Issued.", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Enrollment Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEnterEnrollmentNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtEnterEnrollmentNumber.Text == "")
            {
                txtStudentName.Clear();
                txtDepartment.Clear();
                txtStudentSem.Clear();
                txtStudentCon.Clear();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnterEnrollmentNumber.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
