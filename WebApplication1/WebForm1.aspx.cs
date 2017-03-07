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
        public float CalcPremium(int age, string gender)
        {
            
            

            if (gender == "female")
                if ((age >= 18) && (age <= 30))
                    premium = 5.0F;
                else if (age >= 31)
                    premium = 2.5F;
                else
                    premium = 0.0F;
            else if (gender == "male")
                if ((age >= 18) && (age <= 35))
                    premium = 6.0F;
                else if (age >= 36)
                    premium = 5.0F;
                else premium = 0.0F;
            else
                premium = 0.0F;
            if (age >= 50)
                premium = premium * 0.15F;

            return premium;

        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            int AgeIN = Convert.ToInt32(tbxAge.Text.ToString());
            string GenderIN = tbxGender.Text.ToString();
            CalcPremium(AgeIN, GenderIN);
            lblOutput.Text = string.Format("Your Premium is {0}", premium);
        }
    }
}