using AutomationTest.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace AutomationTest.TEST
{
    class LoginFailed
    {


        IWebDriver webDriver = new ChromeDriver();

        //Hook in Nunit
        [SetUp]
        public void Setup()
        {
            //Navigate to the Website
            webDriver.Navigate().GoToUrl("https://kasina-stg-hr.azurewebsites.net/Account/Login");
            //Comparing of link
            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.Login("", "");
        }

        public void Dispose()
        {
            webDriver.Quit();
        }


        [Test]
        public void EmptyUsername()
        {
            string actUser = webDriver.FindElement(By.CssSelector("#Username-error")).Text;
            string expUser = "The Username field is required.";

            Assert.AreEqual(actUser, expUser);
            Console.WriteLine(actUser);
            Thread.Sleep(3000);
        }

        [Test]
        public void EmptyPassword()
        {
            string actPass = webDriver.FindElement(By.CssSelector("#Password-error")).Text;
            string expPass = "The Password field is required.";

            Assert.AreEqual(actPass, expPass);
            Console.WriteLine(actPass);
            Thread.Sleep(3000);
        }

        [Test]
        public void InvalidEmailAddress()
        {
            //Comparing of link
            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.Login(" ", " ");

            string actEmail = webDriver.FindElement(By.CssSelector("#Username-error")).Text;
            string expEmail = "The Username field is not a valid e-mail address.";

            Assert.AreEqual(actEmail, expEmail);
            Console.WriteLine(actEmail);
            Thread.Sleep(3000);
        }



        [Test]
        public void InvalidUserNameandPassword()
        {
            //Comparing of link
            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.Login("shanon.alipio@mvp.net.ph", "jollyC@me");

            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.Id("toast-container")));

            IWebElement test = webDriver.FindElement(By.ClassName("toast-message"));

            string act = test.Text;
            Console.WriteLine(act);

          
        }
    }
    }
