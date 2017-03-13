using Insurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        float premium;
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            int AgeIN = Convert.ToInt32(tbxAge.Text.ToString());
            string GenderIN = tbxGender.Text.ToString();
            CalculatePremium cp = new CalculatePremium();
            lblOutput.Text = $"{cp.CalcPremium(AgeIN, GenderIN)}";
            //lblOutput.Text = string.Format("Your Premium is {0}", premium);
        }
    }
}