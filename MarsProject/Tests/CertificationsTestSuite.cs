using MarsProject.pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProject.Tests
{
    [TestFixture]
    [Parallelizable]
    class CertificationsTestSuite : Utilities.CommonDriver
    {


        [Test]
        public void AddCertificationsTest()
        {
            LoginPage loginPage = new LoginPage();
            HomePage homeObj = loginPage.performUserLogin("myfriendchowdari@gmail.com", "Kiran123abc");                    
            ProfilePage profile = homeObj.NavigateToProfilePage();
            Certifications certifications = profile.selectCertificationTab();
            certifications.AddCertifications();
            verifytSuccessMessage("ISTQB Certification has been added to your certification");
        }

        [Test]
        public void UpdateCertificationsTest()
        {
            LoginPage loginPage = new LoginPage();
            HomePage homeObj = loginPage.performUserLogin("myfriendchowdari@gmail.com", "Kiran123abc");
            ProfilePage profile = homeObj.NavigateToProfilePage();
            Certifications certifications = profile.selectCertificationTab();
            certifications.UpdateCertifications();
            verifytSuccessMessage("ISTQB CertificationEnglish11 has been updated to your certification");

        }

        [Test]
        public void DeleteCertificationsTest()
        {
            LoginPage loginPage = new LoginPage();
            HomePage homeObj = loginPage.performUserLogin("myfriendchowdari@gmail.com", "Kiran123abc");
            ProfilePage profile = homeObj.NavigateToProfilePage();
            Certifications certifications = profile.selectCertificationTab();
            certifications.DeleteCertification();
            verifytSuccessMessage("Cloud Certification has been deleted from your certification");

        }


    }

}
