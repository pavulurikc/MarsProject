using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsProject.Utilities;

namespace MarsProject.pages
{
   public class HomePage
    {

        public IWebElement getMenuOption(string title)
        {
          return CommonDriver.driver.FindElement(By.XPath("//section[@class='nav-secondary']//a[text()='" + title + "']"));
        }

       public ProfilePage NavigateToProfilePage()
        {
            getMenuOption("Profile").Click();
            return new ProfilePage();
        }
    }
}
