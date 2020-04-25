using MarsProject.pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject.Tests
{
    class EducationTestSuite : Utilities.CommonDriver
    {
        [Test]
        public void AddEducationTest()
        {

            LoginPage loginPage = new LoginPage();
            HomePage homeObj = loginPage.performUserLogin("myfriendchowdari@gmail.com", "Kiran123abc");
            ProfilePage profile = homeObj.NavigateToProfilePage();
            Education Education = profile.selectEducationTab();
            Education.AddEducation();
            verifytSuccessMessage("Education has been added");
  
        }

        [Test]
        public void UpdateEducationTest()
        {
            LoginPage loginPage = new LoginPage();
            HomePage homeObj = loginPage.performUserLogin("myfriendchowdari@gmail.com", "Kiran123abc");
            ProfilePage profile = homeObj.NavigateToProfilePage();
            Education Education = profile.selectEducationTab();
            Education.UpdateEducation();
            verifytSuccessMessage("Education as been updated");

        }

        [Test]
        public void DeleteEducationTest()
        {
            LoginPage loginPage = new LoginPage();
            HomePage homeObj = loginPage.performUserLogin("myfriendchowdari@gmail.com", "Kiran123abc");
            ProfilePage profile = homeObj.NavigateToProfilePage();
            Education Education = profile.selectEducationTab();
            Education.DeleteEducation();
            verifytSuccessMessage("Education entry successfully removed");

        }

    }
}
