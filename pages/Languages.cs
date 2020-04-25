using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsProject.Utilities;
using System.Threading;

namespace MarsProject.pages
{
    public class Languages
    {

        public void AddLanguages()
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

        public void UpdateLanguages()
        {
            Thread.Sleep(2000);

            //To Edit English the one of the language 
            CommonDriver.driver.FindElement(By.XPath("//table[@class='ui fixed table']/tbody[1]/tr/td[3]/span[1]/i")).Click();

            //Identify the AddLanguage Element and Add Text to it
            CommonDriver.driver.FindElement(By.XPath("//div[@class='five wide field']/input")).SendKeys("English11");

            //Identify the Update Element and Click on it
            CommonDriver.driver.FindElement(By.XPath("//span[@class='buttons-wrapper']/input[1]")).Click();

            
        }

        public void DeleteLanguages()
        {
            Thread.Sleep(2000);

            //To Delete Last Row English11 the one of the language 
            CommonDriver.driver.FindElement(By.XPath("//table[@class='ui fixed table']/tbody[4]/tr/td[3]/span[2]/i")).Click();

            
        }

    }

}
