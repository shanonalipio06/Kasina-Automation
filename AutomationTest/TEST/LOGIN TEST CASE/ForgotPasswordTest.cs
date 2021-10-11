using AutomationTest.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

using System.Threading;

namespace AutomationTest.TEST.LOGIN_TEST_CASE
{
    class ForgotPasswordTest
    {

        IWebDriver webDriver = new ChromeDriver(@"C:\Users\shanon.alipio\Documents\GitHub\Kasina-Automation\AutomationTest\Drivers\");

        //Hook in Nunit
        [SetUp]
        public void Setup()
        {
            //Navigate to the Website
            webDriver.Navigate().GoToUrl("https://kasina-stg-hr.azurewebsites.net/Account/ForgotPassword");

        }

        public void Dispose()
        {
            webDriver.Quit();
        }


        [Test]
        public void SendEmailSuccessfully()
        {
            ForgotPassword forgot = new ForgotPassword(webDriver);
            forgot.SendEmail("kasina.admin@mvp.net.ph");

            Thread.Sleep(3000);
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.Id("toast-container")));

            IWebElement test = webDriver.FindElement(By.ClassName("toast-message"));

            string act = test.Text;
            Console.WriteLine(act);
            Thread.Sleep(3000);

        }
        [Test]
        public void InvalidEmail()
        {
            ForgotPassword forgot = new ForgotPassword(webDriver);
            forgot.SendEmail("kasina.admin@mvp.net.phss");

           
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.Id("toast-container")));

            IWebElement test = webDriver.FindElement(By.ClassName("toast-message"));

            string act = test.Text;
            Console.WriteLine(act);


        }
    }
}
