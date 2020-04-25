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
    public class Education
    {

        public void AddEducation()
        {
            //initializeDriver(browsesrName);
            //LoginPage.performUserLogin(userName, password);

            Thread.Sleep(2000);

            //To Click on the Education button
            CommonDriver.driver.FindElement(By.XPath("//form[@class='ui form']/div/a[3]")).Click();

            //To click on AddNew Button
            CommonDriver.driver.FindElement(By.XPath("//div[@data-tab='third']//div[text()='Add New']")).Click();

            //To Write on College/University/Name
            CommonDriver.driver.FindElement(By.XPath("//input[@name='instituteName']")).SendKeys("Bellary Engineering College");

            //To Select Country Name from Dropdown List
            CommonDriver.driver.FindElement(By.XPath("//select[@name='country']/option[66]")).Click();

            //To Select Title from Dropdown List
            CommonDriver.driver.FindElement(By.XPath("//select[@name='title']/option[7]")).Click();

            //To Write on Degree Name
            CommonDriver.driver.FindElement(By.XPath("//input[@name='degree']")).SendKeys("Computer Sceince Engineering");

            //To Select Year of Gra from Dropdown List
            CommonDriver.driver.FindElement(By.XPath("//select[@name='yearOfGraduation']/option[14]")).Click();

            //Identify the Add Button and click on it
            CommonDriver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]")).Click();

            //To Click on the Education button
            CommonDriver.driver.FindElement(By.XPath("//form[@class='ui form']/div/a[3]")).Click();

            Thread.Sleep(2000);

            //To click on AddNew Button
            CommonDriver.driver.FindElement(By.XPath("//div[@data-tab='third']//div[text()='Add New']")).Click();

            //To Write on College/University/Name
            CommonDriver.driver.FindElement(By.XPath("//input[@name='instituteName']")).SendKeys("Manipal University");

            //To Select Country Name from Dropdown List
            CommonDriver.driver.FindElement(By.XPath("//select[@name='country']/option[66]")).Click();

            //To Select Title from Dropdown List
            CommonDriver.driver.FindElement(By.XPath("//select[@name='title']/option[10]")).Click();

            //To Write on Degree Name
            CommonDriver.driver.FindElement(By.XPath("//input[@name='degree']")).SendKeys("Master Of Business Administration");

            //To Select Year of Gra from Dropdown List
            CommonDriver.driver.FindElement(By.XPath("//select[@name='yearOfGraduation']/option[11]")).Click();

            //Identify the Add Button and clink on it
            CommonDriver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]")).Click();

          
        }

        public void UpdateEducation()
        {
            /////////////* To Edit and  Update Functionality on the Education */////////////////////

            Thread.Sleep(2000);

            //To Edit English the one of the language 
            CommonDriver.driver.FindElement(By.XPath("//table[@class='ui fixed table']/tbody[1]/tr/td[6]/span[1]/i")).Click();

            //Identify the AddLanguage Element and Add Text to it
            CommonDriver.driver.FindElement(By.XPath("//div[@class='ten wide field']/input")).SendKeys("English11");

            //Identify the Update Element and Click on it
            CommonDriver.driver.FindElement(By.XPath("//div[@class='sixteen wide field']/input[1]")).Click();

            
        }

        public void DeleteEducation()
        {
            //////////////////* To Delete Operation on the Row in the Education *//////////////////

            Thread.Sleep(2000);

            //To Edit English the one of the language 
            CommonDriver.driver.FindElement(By.XPath("//table[@class='ui fixed table']/tbody[2]/tr/td[6]/span[2]/i")).Click();


        }

    }
}
