using OpenQA.Selenium;

namespace Kasina_HR_Portal.Pages.Settings.Gender
{
    public class GenderPage
    {
        public GenderPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; set; }


        IWebElement btnSettings => Driver.FindElement(By.CssSelector("#navigation-menu > div > a.list-group-item.settings"));

        IWebElement btnGender => Driver.FindElement(By.CssSelector("#settings-menu-item > a:nth-child(1)"));

        IWebElement btnAddgender => Driver.FindElement(By.CssSelector("#add-gender-button"));
        IWebElement btnEditgender => Driver.FindElement(By.CssSelector("#grid > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(3) > td:nth-child(3) > img.action-button.edit-button"));

        IWebElement btnDeletegender => Driver.FindElement(By.CssSelector("#grid > div.k-grid-content.k-auto-scrollable > table > tbody > tr:nth-child(3) > td:nth-child(3) > img.action-button.delete-button"));

        // Methods for clicking the link of the pages

        public void ClickSettings()
        {
            btnSettings.Click();
        }
        public void ClickGender()
        {
            btnGender.Click();
        }


        public void ClickAddGender()
        {
            btnAddgender.Click();
        }

        public void ClickEditGender()
        {
            btnEditgender.Click();
        }

        public void ClickDeleteGender()
        {
            btnDeletegender.Click();
        }
    }
}
