using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibraryManagementSystem
{
    public partial class viewbook : Form
    {
        public viewbook()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void viewbook_Load(object sender, EventArgs e)
        {
            panel2.Visible= false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-EQA9CU4 ; database =library;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = " select * from newbook";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource= ds.Tables[0];
        }
        int bid;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!= null)
            {
                bid =int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-EQA9CU4 ; database =library;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = " select * from newbook where bid = '"+bid+"'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            textBox2.Text = ds.Tables[0].Rows[0][1].ToString();
            textBox3.Text = ds.Tables[0].Rows[0][2].ToString();
            textBox4.Text = ds.Tables[0].Rows[0][3].ToString();
            textBox5.Text = ds.Tables[0].Rows[0][4].ToString();
            textBox6.Text = ds.Tables[0].Rows[0][5].ToString();
            textBox7.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                panel2.Visible = false;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-EQA9CU4 ; database =library;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " select * from newbook where bName like '"+textBox1.Text+"%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-EQA9CU4 ; database =library;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " select * from newbook where bName like '" + textBox1.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            panel2.Visible=false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be UPDATED.confirm??", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                string bname = textBox2.Text;
                string authur = textBox3.Text;
                string publication = textBox4.Text;
                string pdate = textBox5.Text;
                string price = textBox6.Text;
                string quant = textBox7.Text;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-EQA9CU4 ; database =library;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " update newbook set bName ='" + bname + "', bAuthur = '" + authur + "', bPublic ='" + publication + "', bPDate = '" + pdate + "',bPrice = '" + price + "', bquantity='" + quant + "' where bid = '" + rowid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted.confirm??", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-EQA9CU4 ; database =library;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " delete from newbook where bid = '" + rowid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }
    }
}
