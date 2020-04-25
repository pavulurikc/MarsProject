using MarsProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsProject.Utilities;

namespace MarsProject.pages
{
    class LoginPage 
    {      

        //reusable methods
        public HomePage performUserLogin(string name, string password)
        {
            CommonDriver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a")).Click();

            //identify the username and enter username value
            CommonDriver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input")).SendKeys(name);

            //identify the password and enter password value
            CommonDriver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input")).SendKeys(password);

            //identify the login button and click on it
            CommonDriver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();

            return new HomePage();
        }
    }
}
