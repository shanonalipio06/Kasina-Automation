using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Kasina_HR_Portal.Pages.Settings.Gender;
using AutomationTest.Pages;

namespace Kasina_HR_Portal.Test_Cases.Positive_Testing.Settings
{
    class GenderSuccess
    {
        public static IWebDriver webDriver = new ChromeDriver();
        GenderPage genderPage = new GenderPage(webDriver);
        AddNewGenderPage addGenderPage = new AddNewGenderPage(webDriver);



        //Hook in Nunit
        [SetUp]
        public void Setup()
        {
            //Navigate to the Website
            webDriver.Navigate().GoToUrl("https://kasina-stg-hr.azurewebsites.net/Account/Login");
            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.Login("kasina.admin@mvp.net.ph", "Password123");

        }

        public void GenderPage()
        {
            Thread.Sleep(1000);
            genderPage.ClickSettings();
            genderPage.ClickGender();

        }


        [Test]
        public void AddGender()
        {
            // Redirecting to the Page
            Thread.Sleep(2500);
            GenderPage();
            genderPage.ClickAddGender();
            addGenderPage.genderName("testGender");

            //Add Assert testing still has an issue
            string test = webDriver.FindElement(By.Name("testGender")).Text;
            Assert.Equals(test, "testGender");

            Thread.Sleep(2000);

        }
    }
}
