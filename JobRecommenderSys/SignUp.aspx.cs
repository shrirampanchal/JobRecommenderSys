using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobRecommenderSys
{
    public partial class SignUp : System.Web.UI.Page
    {
        //read function disabled
        SqlConnection connection = new SqlConnection("Server=(local);Database=JobRecommenderDb;Integrated Security=true");

        string username,email, pwd, city, contactno;

        private void readValues()
        {
            username = txtUserName.Text;
            email = txtEmail.Text;
            pwd = txtPassword.Text;
            city = txtCity.Text;
            contactno = txtContact.Text;


        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            connection.Open();


            if (connection.State == System.Data.ConnectionState.Open)
            {
               // readValues();

                SqlCommand sqlCommand = new SqlCommand("insert into RecruiterInfo(username,email,password,city,contactno) values('"+username+"','"+email+"','"+pwd+"','"+city+"','"+contactno+"')", connection);
               int x = sqlCommand.ExecuteNonQuery();

                if(x>0)
                Response.Write("<script>alert('User Registered successfully');</script>");
                else
                    Response.Write("<script>alert('Unable to register');</script>");
            }
            else
                Response.Write("<script>alert('Connection Error');</script>");
        }
    }
}