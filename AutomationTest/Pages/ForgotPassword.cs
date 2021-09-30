using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTest.Pages
{
    public class ForgotPassword
    {
       

        public ForgotPassword(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }
        
        
        IWebElement txtUserName => Driver.FindElement(By.Name("Username"));
        IWebElement btnResetpassword => Driver.FindElement(By.XPath("//*[@id='submit']"));

        IWebElement lnkBack => Driver.FindElement(By.LinkText("Back"));

        //Entering value on the field

        public void SendEmail(string username)
        {
            txtUserName.SendKeys(username);
            btnResetpassword.Submit();
        }


        // Link click
        /* public void ClickBack()
         {
            lnkBack.Click();
        }*/


     
       

     
  

    }

}

