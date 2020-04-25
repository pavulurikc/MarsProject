using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsProject.Utilities;

namespace MarsProject.pages
{
    public class ProfilePage
    {

        public Certifications selectCertificationTab()
        {
            //To Click on the Certifications button
            CommonDriver.driver.FindElement(By.XPath("//a[text()='Certifications']")).Click();
            return new Certifications();
        }

        public Education selectEducationTab()
        {
            //To Click on the Education button
            CommonDriver.driver.FindElement(By.XPath("//a[text()='Education']")).Click();
            return new Education();
        }

        public Languages selectLanguagesTab()
        {
            //To Click on the Languages button

            CommonDriver.driver.FindElement(By.XPath("//a[text()='Languages']")).Click();
            return new Languages();
        }

        public Skills selectSkillsTab()
        {
            //To Click on the Skills button
            CommonDriver. driver.FindElement(By.XPath("//a[text()='Skills']")).Click();
            return new Skills();
        }
    }
}
