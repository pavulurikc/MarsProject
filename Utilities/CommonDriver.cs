using MarsProject.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;

namespace MarsProject.Utilities
{
    public class CommonDriver
    {

        private static IWebDriver webDriver = null;

        //init webdriver globally
        public static IWebDriver driver {

            get { return webDriver; }

            set { webDriver = value; }
        }




        [SetUp]
        public void sertUp()
        {
            string browserName = ConfigurationManager.AppSettings["browserName"];
            initializeDriver(browserName);
        }

        [TearDown]
        public void tearDown()
        {
            if(driver != null)
            {
                driver.Close();
                driver.Quit();
            }
        }


        public static void initializeDriver(string browserName)
        {
            if (browserName.ToUpper() == "CHROME")
            {
                //open up chrome browser
                driver = new ChromeDriver();

                //To Maximaze the Window
                driver.Manage().Window.Maximize();

                //enter the url
                driver.Navigate().GoToUrl("http://localhost:5000/Home");

                //defining the Implicit wait
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }
        }

        public static void verifytSuccessMessage(string message)
        {
            By by = By.XPath("//div[contains(@class,'ns-type-success')]//div[contains(@class,'ns-box-inner')]");
            Assert.AreEqual(driver.FindElement(by).Text, message);
        }


    }
}

