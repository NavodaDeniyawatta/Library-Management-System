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
using Microsoft.Identity.Client;

namespace LibraryManagementSystem
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookAuthurName.Text != "" && txtBookName.Text != "" && txtBookPrice.Text != "" && txtBookPublication.Text != "" && txtBookQuantity.Text != "") 
            {
                string bname = txtBookName.Text;
                string authur = txtBookAuthurName.Text;
                string publication = txtBookPublication.Text;
                DateOnly pdate = DateOnly.Parse(dateTimePicker1.Text);
                string price = txtBookPrice.Text;
                string quant = txtBookQuantity.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-EQA9CU4 ; database =library;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = " insert into newbook (bName, bAuthur, bPublic, bPDate, bPrice, bquantity) values ('" + bname + "','" + authur + "','" + publication + "','" + pdate + "','" + price + "','" + quant + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookAuthurName.Clear();
                txtBookPublication.Clear();
                txtBookPrice.Clear();
                txtBookQuantity.Clear();
                txtBookName.Clear();

            }
            else
            {
                MessageBox.Show("Empty fields NOT allowed.", "Error" , MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will DELETE your unsaved Data.Are you sure?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
