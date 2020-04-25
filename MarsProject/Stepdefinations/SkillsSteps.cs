using MarsProject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsProject.Stepdefinations
{
    [Binding]
    public class SkillsSteps : Utilities.CommonDriver
    {
        [When(@"I can click on skills")]
        public void WhenICanClickOnSkills()
        {
            CommonDriver.driver.FindElement(By.XPath("//a[text()='Skills']")).Click();
        }
        
        [When(@"I can Add data by clicking AddNew button in skills")]
        public void WhenICanAddDataByClickingAddNewButtonInSkills()
        {
            Thread.Sleep(2000);

            //To Click on the Skills button
            CommonDriver.driver.FindElement(By.XPath("//form[@class='ui form']/div/a[2]")).Click();

            //To Click on AddNew button
            CommonDriver.driver.FindElement(By.XPath("//div[@data-tab='second']//div[text()='Add New']")).Click();

            //Identify the Add Skill Button and send Data
            CommonDriver.driver.FindElement(By.XPath("//input[@placeholder='Add Skill']")).SendKeys("ISTQB");

            //Identify the Choose Skill Level and select the Beginner option
            CommonDriver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']/option[2]")).Click();

            //Identify the Add button and Click on it
            CommonDriver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();

            Thread.Sleep(2000);

            //To Click on AddNew button
            CommonDriver.driver.FindElement(By.XPath("//div[@data-tab='second']//div[text()='Add New']")).Click();

            //To Add Skill Text Box
            CommonDriver.driver.FindElement(By.XPath("//input[@placeholder='Add Skill']")).SendKeys("Cloud");

            //Identify the Choose Skill Level and select the Beginner option
            CommonDriver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']/option[3]")).Click();

            //Identify the Add button and Click on it
            CommonDriver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();

            Thread.Sleep(2000);

            //To Click on AddNew button
            CommonDriver.driver.FindElement(By.XPath("//div[@data-tab='second']//div[text()='Add New']")).Click();

            //To Add Skill Text Box
            CommonDriver.driver.FindElement(By.XPath("//input[@placeholder='Add Skill']")).SendKeys("Scrum");

            //Identify the Choose Skill Level and select the Beginner option
            CommonDriver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']/option[4]")).Click();

            //Identify the Add button and Click on it
            CommonDriver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();

        }

        [When(@"I can Edit and Update the Entiry in skills")]
        public void WhenICanEditAndUpdateTheEntiryInSkills()
        {
            Thread.Sleep(2000);

            //To Edit English the one of the language 
            CommonDriver.driver.FindElement(By.XPath("//div[@data-tab='second']/div/div/div/table/tbody[1]/tr/td[3]/span[1]/i")).Click();

            //Identify the AddLanguage Element and Add Text to it
            CommonDriver.driver.FindElement(By.XPath("//div[@class='five wide field']/input")).SendKeys("Scrum11");

            //Identify the Update Element and Click on it
            CommonDriver.driver.FindElement(By.XPath("//span[@class='buttons-wrapper']/input[1]")).Click();
        }

        [When(@"I can Delete the entiry in skills")]
        public void WhenICanDeleteTheEntiryInSkills()
        {
            ////////////////* To Delete Operation on the Row in the Skills *//////////////////

            Thread.Sleep(2000);

            //To Edit English the one of the language 
            CommonDriver.driver.FindElement(By.XPath("//div[@data-tab='second']/div/div/div/table/tbody[3]/tr/td[3]/span[2]/i")).Click();

        }

        [Then(@"I can Verify Success Message '(.*)'")]
        public void ThenICanVerifySuccessMessage(string message)
        {
            By by = By.XPath("//div[contains(@class,'ns-type-success')]//div[contains(@class,'ns-box-inner')]");
            Assert.AreEqual(CommonDriver.driver.FindElement(by).Text, message);
        }

    }
}
