//using System;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Support.UI;

//namespace SeleniumTests
//{
//    [TestFixture]
//    public class SeleniumTesting
//    {
//        private IWebDriver driver;
//        private StringBuilder verificationErrors;
//        private string baseURL;
//        private bool acceptNextAlert = true;[SetUp]
//        public void SetupTest()
//        {
//            driver = new FirefoxDriver(); baseURL = "http://localhost:59931/WebForm1.aspx";
//            verificationErrors = new StringBuilder();
//        }
//        [TearDown]
//        public void TeardownTest()
//        {
//            try { driver.Quit(); }
//            catch (Exception)
//            { // Ignore errors if unable to close the browser 
//            }
//            Assert.AreEqual("", verificationErrors.ToString());
//        }
//        [Test]
//        public void TheSeleniumTestingTest()
//        {
//            driver.Navigate().GoToUrl(baseURL + "/WebForm1.aspx"); driver.FindElement(By.Id("tbxAge")).Clear();
//            driver.FindElement(By.Id("tbxAge")).SendKeys("33"); driver.FindElement(By.Id("tbxGender")).Clear();
//            driver.FindElement(By.Id("tbxGender")).SendKeys("female"); driver.FindElement(By.Id("Button1")).Click();
//        }
//        private bool IsElementPresent(By by)
//        {
//            try { driver.FindElement(by); return true; }
//            catch (NoSuchElementException) { return false; }
//        }
//        private bool IsAlertPresent()
//        {
//            try
//            { driver.SwitchTo().Alert(); return true; }
//            catch (NoAlertPresentException) { return false; }
//        }
//        private string CloseAlertAndGetItsText()
//        {
//            try
//            {
//                IAlert alert = driver.SwitchTo().Alert();
//                string alertText = alert.Text;
//                if (acceptNextAlert)
//                {
//                    alert.Accept();
//                }
//                else
//                { alert.Dismiss(); }
//                return alertText;
//            }
//            finally { acceptNextAlert = true; }
//        }
//    }
//}
using System; 
using System.Text; 
using System.Text.RegularExpressions; 
using System.Threading; 
using NUnit.Framework; 
using OpenQA.Selenium; 
using OpenQA.Selenium.Firefox; 
using OpenQA.Selenium.Support.UI; 
namespace SeleniumTests
{
    [TestFixture]
    public class SeleniumTesting
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;[SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost:59931";
            verificationErrors = new StringBuilder();
            //WebDriverWait wait = new WebDriverWait(driver, 10);
            //wait.Until(ExpectedConditions.InvisibilityOfElementLocated((By.Id("id"))));
            //driver.Url = "http://somedomain/url_that_delays_loading";
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //IWebElement myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(By.Id("id")));
        }
        [TearDown]
        public void TeardownTest()
        {
            try { driver.Quit(); }
            catch (Exception)
            { // Ignore errors if unable to close the browser
            } Assert.AreEqual("", verificationErrors.ToString());
        }
        [Test]
        public void TheSeleniumTestingTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/WebForm1.aspx");
            driver.FindElement(By.Id("tbxAge")).Clear();
            driver.FindElement(By.Id("tbxAge")).SendKeys("35");
            driver.FindElement(By.Id("tbxGender")).Clear();
            driver.FindElement(By.Id("tbxGender")).SendKeys("female");
            driver.FindElement(By.Id("Button1")).Click();
        }
        [Test]
        public void TheSeleniumTestingTest2()
        {
            driver.Navigate().GoToUrl(baseURL + "/WebForm1.aspx");
            driver.FindElement(By.Id("tbxAge")).Clear();
            driver.FindElement(By.Id("tbxAge")).SendKeys("35");
            driver.FindElement(By.Id("tbxGender")).Clear();
            driver.FindElement(By.Id("tbxGender")).SendKeys("male");
            driver.FindElement(By.Id("Button1")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {driver.FindElement(by); return true;}
            catch (NoSuchElementException)
            { return false; }
        }
        private bool IsAlertPresent()
        {
            try { driver.SwitchTo().Alert(); return true; }
            catch (NoAlertPresentException) { return false; }
        }
        private string CloseAlertAndGetItsText()
        {
            try { IAlert alert = driver.SwitchTo().Alert(); string alertText = alert.Text;
                if (acceptNextAlert) { alert.Accept(); }
                else { alert.Dismiss(); }
                return alertText; } finally { acceptNextAlert = true; }
        }
    }
}
