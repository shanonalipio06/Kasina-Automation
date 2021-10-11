using AutomationTest.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

using System.Threading;


namespace AutomationTest.TEST
{
    class LoginSuccessTest
    {

        IWebDriver webDriver = new ChromeDriver();

        //Hook in Nunit
        [SetUp]
        public void Setup()
        {
            //Navigate to the Website
            webDriver.Navigate().GoToUrl("https://kasina-stg-hr.azurewebsites.net/Account/Login");

        }

        public void Dispose()
        {
            webDriver.Quit();
        }


        [Test]
        public void Login()
        {
            //Comparing of link
            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.Login("kasina.admin@mvp.net.ph", "Password123");

            Thread.Sleep(1000);


            string act = webDriver.Url;
            string exp = "https://kasina-stg-hr.azurewebsites.net/Dashboard/Index";
            Assert.AreEqual(act, exp);

            Console.WriteLine("User was able to logged in");

        }
    }
}

