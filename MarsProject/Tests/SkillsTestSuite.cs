using MarsProject.pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject.Tests
{
    class SkillsTestSuite : Utilities.CommonDriver
    {

        [Test]
        public void AddSkillsTest()
        {
            LoginPage loginPage = new LoginPage();
            HomePage homeObj = loginPage.performUserLogin("myfriendchowdari@gmail.com", "Kiran123abc");
            ProfilePage profile = homeObj.NavigateToProfilePage();
            Skills Skills = profile.selectSkillsTab();
            Skills.AddSkills();
            verifytSuccessMessage("Cloud has been added to your skills");
                       
        }

        [Test]
        public void UpdateSkillsTest()
        {
            LoginPage loginPage = new LoginPage();
            HomePage homeObj = loginPage.performUserLogin("myfriendchowdari@gmail.com", "Kiran123abc");
            ProfilePage profile = homeObj.NavigateToProfilePage();
            Skills Skills = profile.selectSkillsTab();
            Skills.UpdateSkills();
            verifytSuccessMessage("ISTQBScrum11 has been updated to your skills");


        }

        [Test]
        public void DeleteSkillsTest()
        {
            LoginPage loginPage = new LoginPage();
            HomePage homeObj = loginPage.performUserLogin("myfriendchowdari@gmail.com", "Kiran123abc");
            ProfilePage profile = homeObj.NavigateToProfilePage();
            Skills Skills = profile.selectSkillsTab();
            Skills.DeleteSkills();
            verifytSuccessMessage("Scrum has been deleted");

        }


       
    }
}
