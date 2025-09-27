using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem
{
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchEnrollment_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEnrollment.Text != "")
            {
                label1.Visible=false;
                Image Image = Image.FromFile("D:/BIT/LEVEL 1 SEMESTER 2/ITE 1942 - ICT Project/10th Week - Application development using a Visual Programming Language/Liberay Management System/search1.gif");
                pictureBox1.Image= Image;

                panel2.Visible = false;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-EQA9CU4 ; database =library;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " select * from newStudent where sEnroll like '" + txtSearchEnrollment.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                label1.Visible=true;
                Image Image = Image.FromFile("D:/BIT/LEVEL 1 SEMESTER 2/ITE 1942 - ICT Project/10th Week - Application development using a Visual Programming Language/Liberay Management System/search.gif");
                pictureBox1.Image= Image;

                panel2.Visible = false;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-EQA9CU4 ; database =library;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " select * from newStudent where sEnroll like '" + txtSearchEnrollment.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-EQA9CU4 ; database =library;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = " select * from newStudent";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        int sid;
        Int64 Rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                sid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-EQA9CU4 ; database =library;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = " select * from newStudent where sid = '" + sid + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            Rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            textBox2.Text = ds.Tables[0].Rows[0][1].ToString();
            textBox3.Text = ds.Tables[0].Rows[0][2].ToString();
            textBox4.Text = ds.Tables[0].Rows[0][3].ToString();
            textBox5.Text = ds.Tables[0].Rows[0][4].ToString();
            textBox6.Text = ds.Tables[0].Rows[0][5].ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchEnrollment.Clear();
            panel2.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted.confirm??", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-EQA9CU4 ; database =library;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " delete from newStudent where sid= '" + Rowid + "' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be UPDATED.confirm??", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                string sName = textBox2.Text;
                int sEnroll = int.Parse(textBox3.Text);
                string sDep = textBox4.Text;
                string sSem = textBox5.Text;
                string sContact = textBox6.Text;



                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-EQA9CU4 ; database =library;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " update newStudent set sName ='" + sName + "', sEnroll = '" + sEnroll + "', sDep ='" + sDep + "', sSem = '" + sSem + "',sMobile = '" + sContact + "'  where sid = '" + Rowid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
