using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Loginater
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*Response.Write("Submitted");*/
            /*Button1.Text = "Submitted";*/

            string password = TextBox2.Text;
            string result;

            if (password.Length < 8)
                result = "Invalid Length";
            else if (!password.Any(char.IsDigit))
                result = "Needs a digit";
            else if (!password.Any(char.IsLower))
                result = "Needs a lowercase";
            else if (!password.Any(char.IsUpper))
                result = "Needs an uppercase";
            else
                result = ".";

            Response.Write(result);
            if (result==".")
                
                /*Response.Write("Submitted");*/
                Button1.Text = "Submitted";

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
     
        }

  
    }
}