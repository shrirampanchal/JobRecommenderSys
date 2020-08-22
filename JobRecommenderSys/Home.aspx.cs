using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobRecommenderSys
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Response.Write("");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            

            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (email == "")
                Response.Write("<script>alert('enter email');</script>");
            else if (password == "")
                Response.Write("<script>alert('enter Password');</script>");
            else if (email == "kasturi@gmail.com" && password == "1234")
                //Response.Redirect("UserDashboard.aspx");
                Response.Write("<script>alert('Login Successfull');window.location='UserDashboard.aspx';</script>");
            else
                Response.Write("<script>alert('Invalid Credentials');</script>");



        }

        protected void lnkSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }
    }
}