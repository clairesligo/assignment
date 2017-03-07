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
        [Test]
        public void CalcPremium()
        {
            CalculatePremium sut = new CalculatePremium();

            float female25 = sut.CalcPremium(25, "female");
            Assert.That(female25, Is.EqualTo(5));

            float female17 = sut.CalcPremium(17, "female");
            Assert.That(female17, Is.EqualTo(0));

            float noGender = sut.CalcPremium(25, "N");
            Assert.That(noGender, Is.EqualTo(0));

            float male30 = sut.CalcPremium(30, "male");
            Assert.That(male30, Is.EqualTo(6));

            float male40 = sut.CalcPremium(40, "male");
            Assert.That(male40, Is.EqualTo(5));

            float male17 = sut.CalcPremium(17, "male");
            Assert.That(male17, Is.EqualTo(0));
        }
    }
}
