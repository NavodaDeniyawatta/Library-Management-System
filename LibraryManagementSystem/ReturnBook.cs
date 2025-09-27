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
using static System.Windows.Forms.AxHost;


namespace LibraryManagementSystem
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void btsSearchStudent_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-EQA9CU4 ; database =library;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = " select * from IRbook where std_enroll like '" + txtEnterEnrollmentNumber.Text + "'and book_return_date is null";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid ID or No Book Issued.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string bname;
        string bdate;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                bdate = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            txtBook.Text = bname;
            txtIssue.Text = bdate;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-EQA9CU4 ; database =library;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd.CommandText = "update IRbook set book_return_date = '" + textBox4.Text + "' where std_enroll = '" + txtEnterEnrollmentNumber.Text + "' and id = '" + rowid + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Book Returned", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ReturnBooks_Load(this, null);
        }

        private void ReturnBooks_Load(ReturnBook returnBook, object value)
        {
           
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

        private void txtEnterEnrollmentNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtEnterEnrollmentNumber.Text == "")
            {
                panel1.Visible= false;
                dataGridView1.DataSource= null;
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
           panel1.Visible= false;
        }
    }
}
