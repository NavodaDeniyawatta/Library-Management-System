using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace LibraryManagementSystem;

public partial class frmLogin : Form
{
    public frmLogin()
    {
        InitializeComponent();
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void textBox1_MouseEnter(object sender, EventArgs e)
    {
       
    }

    private void txtUserName_MouseClick(object sender, MouseEventArgs e)
    {
        if (txtUsername.Text == "Username");
        {
            txtUsername.Clear();
        }
    }

    private void txtPassword_MouseClick(object sender, MouseEventArgs e)
    {
        if (txtPassword.Text == "Password");
        { 
            txtPassword.Clear();
            txtPassword.PasswordChar = '*';
        }
    }

    private void pictureBoxFaceBook_Click(object sender, EventArgs e)
    {
     System.Diagnostics.Process.Start("https://web.facebook.com/login/?_rdc=1&_rdr");
    }


    private void frmLogin_Load(object sender, EventArgs e)
    {

    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "data source = DESKTOP-EQA9CU4 ; database =library;integrated security = True";
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;

        cmd.CommandText = " select * from logintable where Username ='" + txtUsername.Text + "'and Password='" + txtPassword.Text + "'";
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);

        if (ds.Tables[0].Rows.Count != 0)
        {
            this.Hide();
            frmDashboard dsa = new frmDashboard ();
            dsa.Show();
        }
        else
        {
            MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    private void txtUsername_TextChanged(object sender, EventArgs e)
    {

    }

    private void pictureBoxInsta_Click(object sender, EventArgs e)
    {
        System.Diagnostics.Process.Start("https://www.instagram.com/accounts/login/");
    }

    private void pictureBoxTwitter_Click(object sender, EventArgs e)
    {
        System.Diagnostics.Process.Start("https://twitter.com/?lang=en");
    }

    private void btnSignUp_Click(object sender, EventArgs e)
    {
        SignUP su = new SignUP ();
        su.Show();
    }
}