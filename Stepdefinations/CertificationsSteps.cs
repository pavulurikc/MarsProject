using MarsProject.pages;
using MarsProject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsProject.Stepdefinations
{
    [Binding]
    public class CertificationsSteps : Utilities.CommonDriver
    {
        [Given(@"I launch application")]
        public void GivenILaunchApplication()
        {
            string browserName = ConfigurationManager.AppSettings["browserName"];
            initializeDriver(browserName);
        }
        
        [When(@"I am in loginpage")]
        public void WhenIAmInLoginpage()
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
        
        [When(@"I can log into application with '(.*)' and '(.*)'")]
        public void WhenICanLogIntoApplicationWithAnd(string p0, string p1)
        {
            CommonDriver.driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a")).Click();

            //identify the username and enter username value
            CommonDriver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input")).SendKeys("myfriendchowdari@gmail.com");

            //identify the password and enter password value
            CommonDriver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input")).SendKeys("Kiran123abc");

            //identify the login button and click on it
            CommonDriver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();

            //return new HomePage();
        }



        [When(@"I can navigate To (.*) Page")]
        public void WhenICanNavigateToProfilePage(String title)
        {
           CommonDriver.driver.FindElement(By.XPath("//section[@class='nav-secondary']//a[text()='" + title + "']")).Click();
        }

        [When(@"I can click on Certifications")]
        public void WhenICanClickOnCertifications()
        {
            //To Click on the Certifications button
            CommonDriver.driver.FindElement(By.XPath("//a[text()='Certifications']")).Click();
        }

        [When(@"I can Add data by clicking AddNew button")]
        public void WhenICanAddDataByClickingAddNewButton()
        {
            Thread.Sleep(2000);

            //To click on AddNew Button
            CommonDriver.driver.FindElement(By.XPath("//div[@data-tab='fourth']//div[text()='Add New']")).Click();

            //To Enter Certificate or Award
            CommonDriver.driver.FindElement(By.XPath("//input[@name='certificationName']")).SendKeys("ISTQB Certification");

            //To Enter Certified From Text Field
            CommonDriver.driver.FindElement(By.XPath("//input[@name='certificationFrom']")).SendKeys("ISTQB UK");

            //To Select Year 
            CommonDriver.driver.FindElement(By.XPath("//select[@name='certificationYear']/option[5]")).Click();

            //Identify the Add Button and Click on it
            CommonDriver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")).Click();

            //To Click on the Certifications button
            CommonDriver.driver.FindElement(By.XPath("//form[@class='ui form']/div/a[4]")).Click();

            Thread.Sleep(2000);

            //To click on AddNew Button
            CommonDriver.driver.FindElement(By.XPath("//div[@data-tab='fourth']//div[text()='Add New']")).Click();

            //To Enter Certificate or Award
            CommonDriver.driver.FindElement(By.XPath("//input[@name='certificationName']")).SendKeys("Cloud Certification");

            //To Enter Certified From Text Field
            CommonDriver.driver.FindElement(By.XPath("//input[@name='certificationFrom']")).SendKeys("Amazon Web Services");

            //To Select Year 
            CommonDriver.driver.FindElement(By.XPath("//select[@name='certificationYear']/option[3]")).Click();

            //Identify the Add Button and Click on it
            CommonDriver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")).Click();

        }

        [When(@"I can Edit and Update the Entiry")]
        public void WhenICanEditAndUpdateTheEntiry()
        {
            /////////////* To Edit and  Update Functionality on the Certifications */////////////////////

            Thread.Sleep(3000);

            //To Edit Amazon the one of the language 
            CommonDriver.driver.FindElement(By.XPath("//table[@class='ui fixed table']/tbody[1]/tr/td[4]/span[1]/i")).Click();

            //Identify the AddLanguage Element and Add Text to it
            CommonDriver.driver.FindElement(By.XPath("//div[@class='fields']/div[1]/input")).SendKeys("English11");

            //Identify the Update Element and Click on it
            CommonDriver.driver.FindElement(By.XPath("//span[@class='buttons-wrapper']/input[1]")).Click();

        }

        [When(@"I can Delete the entiry")]
        public void WhenICanDeleteTheEntiry()
        {
            //////////////////* To Delete Operation on the Row in the Certifications *//////////////////

            Thread.Sleep(2000);

            //To Edit English the one of the language 
            CommonDriver.driver.FindElement(By.XPath("//table[@class='ui fixed table']/tbody[2]/tr/td[4]/span[2]/i")).Click();
        }

        [Then(@"I can verify success message '(.*)'")]
        public void ThenICanVerifySuccessMessage(string message)
        {
            By by = By.XPath("//div[contains(@class,'ns-type-success')]//div[contains(@class,'ns-box-inner')]");
            Assert.AreEqual(CommonDriver.driver.FindElement(by).Text, message);
        }
    }
}
