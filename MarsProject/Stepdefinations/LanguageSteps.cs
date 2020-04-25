using MarsProject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsProject.Stepdefinations
{
    [Binding]
    public class LanguageSteps : Utilities.CommonDriver
    {
        [When(@"I can click on languages")]
        public void WhenICanClickOnLanguages()
        {
            CommonDriver.driver.FindElement(By.XPath("//a[text()='Languages']")).Click();
        }
        
        [When(@"I can Add data by clicking AddNew button on languages")]
        public void WhenICanAddDataByClickingAddNewButtonOnLanguages()
        {

            Thread.Sleep(2000);

            //Identify the AddNew Element and click on it
            CommonDriver.driver.FindElement(By.XPath("//div[@data-tab='first']//div[text()='Add New']")).Click();

            //Identify the AddLanguage Element and Add Text to it
            CommonDriver.driver.FindElement(By.XPath("//div[@class='five wide field']/input")).SendKeys("English");

            //Identify the Choose Language Element and Select the Basic Option
            CommonDriver.driver.FindElement(By.XPath("//div[@class='five wide field']/select/option[2]")).Click();

            //Identify the ADD Element and Click on it
            CommonDriver.driver.FindElement(By.XPath("//div[@class='six wide field']/input[1]")).Click();

            Thread.Sleep(2000);

            //Identify the AddNew Element and click on it
            CommonDriver.driver.FindElement(By.XPath("//div[@data-tab='first']//div[text()='Add New']")).Click();

            //Identify the AddLanguage Element and Add Text to it
            CommonDriver.driver.FindElement(By.XPath("//input[@name='name']")).SendKeys("Maths");

            //Identify the Choose Language Element and Select the Basic Option
            CommonDriver.driver.FindElement(By.XPath("//div[@class='five wide field']/select/option[3]")).Click();

            //To Click on the Add Button
            CommonDriver.driver.FindElement(By.XPath("//div[@class='six wide field']/input[1]")).Click();

            Thread.Sleep(2000);

            //Identify the AddNew Element and click on it
            CommonDriver.driver.FindElement(By.XPath("//div[@data-tab='first']//div[text()='Add New']")).Click();

            //Identify the AddLanguage Element and Add Text to it
            CommonDriver.driver.FindElement(By.XPath("//div[@class='five wide field']/input")).SendKeys("Hindi");

            //Identify the Choose Language Element and Select the Basic Option
            CommonDriver.driver.FindElement(By.XPath("//div[@class='five wide field']/select/option[4]")).Click();

            //To Click on the Add Button
            CommonDriver.driver.FindElement(By.XPath("//div[@class='six wide field']/input[1]")).Click();

            Thread.Sleep(2000);

            //Identify the AddNew Element and click on it
            CommonDriver.driver.FindElement(By.XPath("//div[@data-tab='first']//div[text()='Add New']")).Click();

            //Identify the AddLanguage Element and Add Text to it
            CommonDriver.driver.FindElement(By.XPath("//div[@class='five wide field']/input")).SendKeys("Telugu");

            //Identify the Choose Language Element and Select the Basic Option
            CommonDriver.driver.FindElement(By.XPath("//div[@class='five wide field']/select/option[5]")).Click();

            //To Click on the Add Button
            CommonDriver.driver.FindElement(By.XPath("//div[@class='six wide field']/input[1]")).Click();
        }

        [When(@"I can Edit and Update the Entiry in languages")]
        public void WhenICanEditAndUpdateTheEntiryInLanguages()
        {
            Thread.Sleep(2000);

            //To Edit English the one of the language 
            CommonDriver.driver.FindElement(By.XPath("//table[@class='ui fixed table']/tbody[1]/tr/td[3]/span[1]/i")).Click();

            //Identify the AddLanguage Element and Add Text to it
            CommonDriver.driver.FindElement(By.XPath("//div[@class='five wide field']/input")).SendKeys("English11");

            //Identify the Update Element and Click on it
            CommonDriver.driver.FindElement(By.XPath("//span[@class='buttons-wrapper']/input[1]")).Click();
        }

        [When(@"I can Deletw and Update the Entiry in languages")]
        public void WhenICanDeletwAndUpdateTheEntiryInLanguages()
        {
            Thread.Sleep(2000);

            //To Delete Last Row English11 the one of the language 
            CommonDriver.driver.FindElement(By.XPath("//table[@class='ui fixed table']/tbody[4]/tr/td[3]/span[2]/i")).Click();
        }

        [Then(@"I can verify Success Message '(.*)'")]
        public void ThenICanVerifySuccessMessage(string message)
        {
            By by = By.XPath("//div[contains(@class,'ns-type-success')]//div[contains(@class,'ns-box-inner')]");
            Assert.AreEqual(CommonDriver.driver.FindElement(by).Text, message);
        }


    }
}
