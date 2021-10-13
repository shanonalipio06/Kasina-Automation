using OpenQA.Selenium;

namespace Kasina_HR_Portal.Pages.Settings.Gender
{
    public class AddNewGenderPage
    {
        public AddNewGenderPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; set; }


        IWebElement txtName => Driver.FindElement(By.Name("Name"));

        IWebElement btnLogin => Driver.FindElement(By.XPath("//*[@id='submit']"));

        IWebElement lnkBack => Driver.FindElement(By.LinkText("Back"));


        //Entering value on the field

        public void genderName(string name)
        {
            txtName.SendKeys(name);
            btnLogin.Submit();
        }


        //Back Link
        public void ClickBack()
        {
            lnkBack.Click();
        }
    }
}
