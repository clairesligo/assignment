using Insurance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceFixture
{
    public class FitTest : fit.ColumnFixture
    {
        public string gender;
        public int age;

        CalculatePremium ins = new CalculatePremium();


        public float CalcPremium()
        {
            return ins.CalcPremium(age, gender);
        }
    }
}
