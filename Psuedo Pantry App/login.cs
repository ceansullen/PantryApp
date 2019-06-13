using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;


namespace Psuedo_Pantry_App
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM LOGIN";
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sean_cullen\Documents\userlogin.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            //creating data adapter
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            //data table for login info
            DataTable dt = new DataTable();

            //fill data table with login info
            sda.Fill(dt);
          
            //if login table is empty it will prompt user to create an account
            if(dt.Equals(null))
            {
                CreateUserNoneExist f = new CreateUserNoneExist();
                f.Show();
                string userID = 
                string query2 = "INSERT INTO LOGIN (USERID, PASSWORD, ADMIN, USERNAME)";
                query2 += " VALUES (@USERID, @PASSWORD, 1, USERNAME)";
                SqlCommand myCommand = new SqlCommand(query, conn);
                myCommand.Parameters.AddWithValue("@USERID", );
                myCommand.Parameters.AddWithValue("PASSWORD",);
            
            }

            
        }

        
    }
}
