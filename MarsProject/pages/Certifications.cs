using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MarsProject.Utilities;

namespace MarsProject.pages
{

    public class Certifications
    {


        public void AddCertifications()
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

        public void UpdateCertifications()
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

        public void DeleteCertification()
        {
            //////////////////* To Delete Operation on the Row in the Certifications *//////////////////

            Thread.Sleep(2000);

            //To Edit English the one of the language 
            CommonDriver.driver.FindElement(By.XPath("//table[@class='ui fixed table']/tbody[2]/tr/td[4]/span[2]/i")).Click();

            
        }

    }
}
