using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumTraining.LiteCart
{
    [TestClass]
    public class LoginTest
    {
        private string _url = "http://litecart.resscode.org.ua/admin/";
        private string _adminLogin = "admin";
        private string _adminPass = "admin123";

        [TestMethod]
        public void LoginAsAdmin()
        {
            using (var driver = new ChromeDriver())
            {
                driver.Url = _url;
                driver.FindElement(By.Name("username")).SendKeys(_adminLogin);
                driver.FindElement(By.Name("password")).SendKeys(_adminPass);
                driver.FindElement(By.Name("login")).Click();
                var notice = driver.FindElement(By.ClassName("success"));
                Assert.AreEqual("You are now logged in as admin", notice.Text);
            }
        }
    }
}
