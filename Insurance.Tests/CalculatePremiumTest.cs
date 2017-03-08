using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Insurance.Tests
{
    [TestFixture]
    public class CalculatePremiumTest
    {

        CalculatePremium sut = new CalculatePremium();

        [TestCase(25, "female", ExpectedResult = 5)]
        [TestCase(55, "female", ExpectedResult = 1.25)]
        [TestCase(17, "female", ExpectedResult = 0)]
        [TestCase(25, "N", ExpectedResult = 0)]
        [TestCase(30, "male", ExpectedResult = 6)]
        [TestCase(40, "male", ExpectedResult = 5)]
        [TestCase(17, "male", ExpectedResult = 0)]
        [TestCase(55, "male", ExpectedResult = 2.5)]
        public float pTest(int age, string gender)
        {
            float actualResult = sut.CalcPremium(age, gender);
            return actualResult;
        }
    }
}
