using MarsProject.pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject.Tests
{
    class LanguagesTestSuite : Utilities.CommonDriver
    {


        [Test]
        public void AddLanguagesTest()
        {
            LoginPage loginPage = new LoginPage();
            HomePage homeObj = loginPage.performUserLogin("myfriendchowdari@gmail.com", "Kiran123abc");
            ProfilePage profile = homeObj.NavigateToProfilePage();
            Languages Languages = profile.selectLanguagesTab();
            Languages.AddLanguages();
            verifytSuccessMessage("Hindi has been added to your languages");

        }

        [Test]
        public void UpdateLanguagesTest()
        {
            LoginPage loginPage = new LoginPage();
            HomePage homeObj = loginPage.performUserLogin("myfriendchowdari@gmail.com", "Kiran123abc");
            ProfilePage profile = homeObj.NavigateToProfilePage();
            Languages Languages = profile.selectLanguagesTab();
            Languages.UpdateLanguages();
            verifytSuccessMessage("EnglishEnglish11 has been updated to your languages");

        }

        [Test]
        public void DeleteLanguagesTest()
        {
            LoginPage loginPage = new LoginPage();
            HomePage homeObj = loginPage.performUserLogin("myfriendchowdari@gmail.com", "Kiran123abc");
            ProfilePage profile = homeObj.NavigateToProfilePage();
            Languages Languages = profile.selectLanguagesTab();
            Languages.DeleteLanguages();
            verifytSuccessMessage("Telugu has been deleted from your languages");

        }


    }
}
