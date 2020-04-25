using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsProject.pages;
using System.Threading;
using MarsProject.Utilities;
using NUnit.Framework;

namespace MarsProject
{
    class Program
    {
        static void Main(string[] args)
        {
           
        //    //define driver
        //   CommonDriver.driver = new ChromeDriver();

        //    //page object for Login Page
        //   LoginPage logObj = new LoginPage();
        //    logObj.LoginSteps(CommonDriver.driver);

        //    //page object for home Page
        //    HomePage homeObj = new HomePage();
        //    homeObj.NavigateToProfilePage(CommonDriver.driver);

        //    //Page object for Languages
        //    Languages LangObj = new Languages();
        //    LangObj.AddLanguages(CommonDriver.driver);
        //    LangObj.UpdateLanguages(CommonDriver.driver);
        //    LangObj.DeleteLanguages(CommonDriver.driver);

        //    //page object for Skills
        //    Skills SkillObj = new Skills();
        //    SkillObj.AddSkills(CommonDriver.driver);
        //    SkillObj.UpdateSkills(CommonDriver.driver);
        //    SkillObj.DeleteSkills(CommonDriver.driver);

        //    //page object for Education Page
        //    Education EduObj = new Education();
        //    EduObj.AddEducation(CommonDriver.driver);
        //    EduObj.UpdateEducation(CommonDriver.driver);
        //    EduObj.DeleteEducation(CommonDriver.driver);

        //    //page Object for Certifications
        //    Certifications CertObj = new Certifications();
        //    CertObj.AddCertifications(CommonDriver.driver);
        //    CertObj.UpdateCertifications(CommonDriver.driver);
        //    CertObj.DeleteCertification(CommonDriver.driver);

        }
    }

    //[TestFixture]
    //[Parallelizable]
    //class LanguagesTestSuite : CommonDriver
    ////{
        
    //    [Test]
    //    public void AddLanguagesTest()
    //    {
    //        //page object for home Page
    //        HomePage homeObj = new HomePage();
    //        homeObj.NavigateToProfilePage(driver);

    //        //Page object for Languages
    //        Languages LangObj = new Languages();
    //        LangObj.AddLanguages(driver);
    //    }

    //    [Test]
    //    public void UpdateLanguagesTest()
    //    {
    //        //page object for home Page
    //        HomePage homeObj = new HomePage();
    //        homeObj.NavigateToProfilePage(driver);

    //        //Page object for Languages
    //        Languages LangObj = new Languages();
    //        LangObj.UpdateLanguages(driver);
            
    //    }

    //    [Test]
    //    public void DeleteLanguagesTest()
    //    {
    //        //page object for home Page
    //        HomePage homeObj = new HomePage();
    //        homeObj.NavigateToProfilePage(driver);

    //        //Page object for Languages
    //        Languages LangObj = new Languages();
    //        LangObj.DeleteLanguages(driver);
    //    }

       
    //}

    //[TestFixture]
    //[Parallelizable]
    //class SkillsTestSuite : CommonDriver
    //{
       

    //    [Test]
    //    public void AddSkillsTest()
    //    {
    //        //page object for home Page
    //        HomePage homeObj = new HomePage();
    //        homeObj.NavigateToProfilePage(driver);

    //        //page object for Skills
    //        Skills SkillObj = new Skills();
    //        SkillObj.AddSkills(driver);
            
    //    }

    //    [Test]
    //    public void UpdateSkillsTest()
    //    {
    //        //page object for home Page
    //        HomePage homeObj = new HomePage();
    //        homeObj.NavigateToProfilePage(driver);

           
    //        //page object for Skills
    //        Skills SkillObj = new Skills();
    //        SkillObj.UpdateSkills(driver);
            
    //    }

    //    [Test]
    //    public void DeleteSkillsTest()
    //    {
    //        //page object for home Page
    //        HomePage homeObj = new HomePage();
    //        homeObj.NavigateToProfilePage(driver);

    //        //page object for Skills
    //        Skills SkillObj = new Skills();
    //        SkillObj.DeleteSkills(driver);
    //    }

        
    //}

    //[TestFixture]
    //[Parallelizable]
    //class EducationTestSuite : CommonDriver
    //{
        

    //    [Test]
    //    public void AddEducationTest()
    //    {
    //        //page object for home Page
    //        HomePage homeObj = new HomePage();
    //        homeObj.NavigateToProfilePage(driver);

    //        //page object for Education Page
    //        Education EduObj = new Education();
    //        EduObj.AddEducation(driver);
            
    //    }

    //    [Test]
    //    public void UpdateEducationTest()
    //    {
    //        //page object for home Page
    //        HomePage homeObj = new HomePage();
    //        homeObj.NavigateToProfilePage(driver);

    //        //page object for Education Page
    //        Education EduObj = new Education();
    //        EduObj.UpdateEducation(driver);
            
    //    }

    //    [Test]
    //    public void DeleteEducationTest()
    //    {
    //        //page object for home Page
    //        HomePage homeObj = new HomePage();
    //        homeObj.NavigateToProfilePage(driver);

    //        //page object for Education Page
    //        Education EduObj = new Education();   
    //        EduObj.DeleteEducation(driver);
    //    }

      
    //}

    //[TestFixture]
    //[Parallelizable]
    //class CertificationsTestSuite : CommonDriver
    //{
       

    //    [Test]
    //    public void AddCertificationsTest()
    //    {
    //        //page object for home Page
    //        HomePage homeObj = new HomePage();
    //        homeObj.NavigateToProfilePage(driver);

    //        //page Object for Certifications
    //        Certifications CertObj = new Certifications();
    //        CertObj.AddCertifications(driver);
            
    //    }

    //    [Test]
    //    public void UpdateCertificationsTest()
    //    {
    //        //page object for home Page
    //        HomePage homeObj = new HomePage();
    //        homeObj.NavigateToProfilePage(driver);

    //        //page Object for Certifications
    //        Certifications CertObj = new Certifications();
    //        CertObj.UpdateCertifications(driver);
            
    //    }

    //    [Test]
    //    public void DeleteCertificationsTest()
    //    {
    //        //page object for home Page
    //        HomePage homeObj = new HomePage();
    //        homeObj.NavigateToProfilePage(driver);

    //        //page Object for Certifications
    //        Certifications CertObj = new Certifications();
    //        CertObj.DeleteCertification(driver);
    //    }

       
   //}

}


    //class Program 
    //{
        //static string browsesrName = "CHROME";
        //static string userName = "AAA";
        //static string password = "123";

        //public void Main(string[] args)
        //{
        //   
            // initializeDriver(browsesrName);

            //Test_createAndVerifyDescription();

            //Test_createAndVerifyLanguage();

            //Test_createAndVerifySkills();

            //Test_createAndVerifyEducation();

            //Test_createAndVerifyCertifications();


        //}


        ////Description
        //public static void Test_createAndVerifyDescription()
        //{
        //    //initializeDriver(browsesrName);
        //    //LoginPage.performUserLogin(userName, password);


        //    //// Identify the Description Icon and click to add Description
        //    //getElement(By.XPath("//div[@class='content']//span[@class='button']/i"), "Description Icon").Click();

        //    ////Clear the Text box
        //    //getElement(By.XPath("//textarea[@name='value']"), "Description Clear Text from textbox").Clear();

        //    //////identify the Description Tab and Enter some text
        //    //getElement(By.XPath("//div[@class='field  ']/textarea"), "Description Enter Text Tab").SendKeys("Description of my Profile");

        //    ////Identify the Save button and click on it
        //    //getElement(By.XPath("//button[@type='button']"), "Description Save Icon").Click();

        //    //endTestCase();


        //}

        ////languages
        //public static void Test_createAndVerifyLanguage()
        //{
        //    initializeDriver(browsesrName);
        //    LoginPage.performUserLogin(userName, password);

        //    //Identify the AddNew Element and click on it
        //    getElement(By.XPath("//div[@data-tab='first']//div[text()='Add New']"), "Languages AddNew Button").Click();

        //    //Identify the AddLanguage Element and Add Text to it
        //    getElement(By.XPath("//div[@class='five wide field']/input"), "Add Language in Languages Button").SendKeys("English");

        //    //Identify the Choose Language Element and Select the Basic Option
        //    getElement(By.XPath("//div[@class='five wide field']/select/option[2]"),"Select the option from Choose Language from Languages").Click();

        //    //Identify the ADD Element and Click on it
        //    getElement(By.XPath("//div[@class='six wide field']/input[1]"), "Add Element in Languages").Click();

        //    //Identify the AddNew Element and click on it
        //    getElement(By.XPath("//div[@data-tab='first']//div[text()='Add New']"), "Languages AddNew Button").Click();

        //    //Identify the AddLanguage Element and Add Text to it
        //    getElement(By.XPath("//input[@name='name']"), "Add Language in Languages Button").SendKeys("Maths");

        //    //Identify the Choose Language Element and Select the Basic Option
        //    getElement(By.XPath("//div[@class='five wide field']/select/option[3]"), "Select the option from Choose Language from Languages").Click();

        //    //To Click on the Add Button
        //    getElement(By.XPath("//div[@class='six wide field']/input[1]"), "Add Element in Languages").Click();

        //    //Identify the AddNew Element and click on it
        //    getElement(By.XPath("//div[@data-tab='first']//div[text()='Add New']"), "Languages AddNew Button").Click();

        //    //Identify the AddLanguage Element and Add Text to it
        //    getElement(By.XPath("//div[@class='five wide field']/input"), "Add Language in Languages Button").SendKeys("Hindi");

        //    //Identify the Choose Language Element and Select the Basic Option
        //    getElement(By.XPath("//div[@class='five wide field']/select/option[4]"), "Select the option from Choose Language from Languages").Click();

        //    //To Click on the Add Button
        //    getElement(By.XPath("//div[@class='six wide field']/input[1]"), "Add Element in Languages").Click();

        //    //Identify the AddNew Element and click on it
        //    getElement(By.XPath("//div[@data-tab='first']//div[text()='Add New']"), "Languages AddNew Button").Click();

        //    //Identify the AddLanguage Element and Add Text to it
        //    getElement(By.XPath("//div[@class='five wide field']/input"), "Add Language in Languages Button").SendKeys("Telugu");

        //    //Identify the Choose Language Element and Select the Basic Option
        //    getElement(By.XPath("//div[@class='five wide field']/select/option[5]"), "Select the option from Choose Language from Languages").Click();

        //    //To Click on the Add Button
        //    getElement(By.XPath("//div[@class='six wide field']/input[1]"), "Add Element in Languages").Click();

        //    Console.WriteLine("*************" + getSuccessMessagePopup().Text);
        //    Assert.AreEqual(getSuccessMessagePopup().Text, "");


        //    ///////////* To Edit and  Update Functionality on the Languages */////////////////////

        //    //To Edit English the one of the language 
        //    getElement(By.XPath("//table[@class='ui fixed table']/tbody[4]/tr/td[3]/span[1]/i"), "Click on English Edit button ").Click();

        //    //Identify the AddLanguage Element and Add Text to it
        //    getElement(By.XPath("//div[@class='five wide field']/input"), "Change the Value of Add text in languages").SendKeys("English11");

        //    //Identify the Update Element and Click on it
        //    getElement(By.XPath("//span[@class='buttons-wrapper']/input[1]"), "English11 Updated").Click();

        //    Console.WriteLine("*************" + getSuccessMessagePopup().Text);
        //    Assert.AreEqual(getSuccessMessagePopup().Text, "");


        //    //////////////////* To Delete Operation on the Row in the Languages *//////////////////

        //    //To Delete Last Row English11 the one of the language 
        //    getElement(By.XPath("//table[@class='ui fixed table']/tbody[4]/tr/td[3]/span[2]/i"), "English11 Deleted").Click();

        //    Console.WriteLine("*************" + getSuccessMessagePopup().Text);
        //    Assert.AreEqual(getSuccessMessagePopup().Text, "");


        //    endTestCase();

        //}

        ////Skills
        //public static void Test_createAndVerifySkills()
        //{

        //    initializeDriver(browsesrName);
        //    LoginPage.performUserLogin(userName, password);

        //    //To Click on the Skills button
        //    getElement(By.XPath("//form[@class='ui form']/div/a[2]"),"").Click();

        //    //To Click on AddNew button
        //    getElement(By.XPath("//div[@data-tab='second']//div[text()='Add New']"),"").Click();

        //    //Identify the Add Skill Button and send Data
        //    getElement(By.XPath("//input[@placeholder='Add Skill']"),"").SendKeys("ISTQB");

        //    //Identify the Choose Skill Level and select the Beginner option
        //    getElement(By.XPath("//select[@class='ui fluid dropdown']/option[2]"),"").Click();

        //    //Identify the Add button and Click on it
        //    getElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"),"").Click();


        //    //To Click on AddNew button
        //    getElement(By.XPath("//div[@data-tab='second']//div[text()='Add New']"),"").Click();

        //    //To Add Skill Text Box
        //    getElement(By.XPath("//input[@placeholder='Add Skill']"),"").SendKeys("Cloud");

        //    //Identify the Choose Skill Level and select the Beginner option
        //    getElement(By.XPath("//select[@class='ui fluid dropdown']/option[3]"),"").Click();

        //    //Identify the Add button and Click on it
        //    getElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"),"").Click();


        //    //To Click on AddNew button
        //    getElement(By.XPath("//div[@data-tab='second']//div[text()='Add New']"),"").Click();

        //    //To Add Skill Text Box
        //    getElement(By.XPath("//input[@placeholder='Add Skill']"),"").SendKeys("Scrum");

        //    //Identify the Choose Skill Level and select the Beginner option
        //    getElement(By.XPath("//select[@class='ui fluid dropdown']/option[4]"),"").Click();

        //    //Identify the Add button and Click on it
        //    getElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"),"").Click();

        //    Console.WriteLine("*************" + getSuccessMessagePopup().Text);

        //    ///////////////* To Edit and  Update Functionality on the Skills */////////////////////

        //    //To Edit English the one of the language 
        //    getElement(By.XPath("//div[@data-tab='second']/div/div/div/table/tbody[3]/tr/td[3]/span[1]/i"), "Click on Expert Level Edit button on Skills").Click();

        //    //Identify the AddLanguage Element and Add Text to it
        //    getElement(By.XPath("//div[@class='five wide field']/input"), "Change the Value of Add text in languages").SendKeys("Scrum11");

        //    //Identify the Update Element and Click on it
        //    getElement(By.XPath("//span[@class='buttons-wrapper']/input[1]"), "Click on the Update").Click();


        //    Console.WriteLine("*************" + getSuccessMessagePopup().Text);
        //    Assert.AreEqual(getSuccessMessagePopup().Text, "");

        //    ////////////////* To Delete Operation on the Row in the Skills *//////////////////

        //    //To Edit English the one of the language 
        //    getElement(By.XPath("//div[@data-tab='second']/div/div/div/table/tbody[3]/tr/td[3]/span[2]/i"), "Click on Expert Level Edit button on Skills").Click();


        //    Console.WriteLine("*************" + getSuccessMessagePopup().Text);
        //    Assert.AreEqual(getSuccessMessagePopup().Text, "");


        //    endTestCase();

        //}

        ////Education
        //public static void Test_createAndVerifyEducation()
        //{
        //    initializeDriver(browsesrName);
        //    LoginPage.performUserLogin(userName, password);

        //    //To Click on the Education button
        //    getElement(By.XPath("//form[@class='ui form']/div/a[3]"), "").Click();

        //    //To click on AddNew Button
        //    getElement(By.XPath("//div[@data-tab='third']//div[text()='Add New']"),"").Click();

        //    //To Write on College/University/Name
        //    getElement(By.XPath("//input[@name='instituteName']"),"").SendKeys("Bellary Engineering College");

        //    //To Select Country Name from Dropdown List
        //    getElement(By.XPath("//select[@name='country']/option[66]"),"").Click();

        //    //To Select Title from Dropdown List
        //    getElement(By.XPath("//select[@name='title']/option[7]"),"").Click();

        //    //To Write on Degree Name
        //    getElement(By.XPath("//input[@name='degree']"),"").SendKeys("Computer Sceince Engineering");

        //    //To Select Year of Gra from Dropdown List
        //    getElement(By.XPath("//select[@name='yearOfGraduation']/option[14]"),"").Click();

        //    //Identify the Add Button and click on it
        //    getElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"),"").Click();

        //    //To Click on the Education button
        //    getElement(By.XPath("//form[@class='ui form']/div/a[3]"), "").Click();

        //    //To click on AddNew Button
        //    getElement(By.XPath("//div[@data-tab='third']//div[text()='Add New']"),"").Click();

        //    //To Write on College/University/Name
        //    getElement(By.XPath("//input[@name='instituteName']"),"").SendKeys("Manipal University");

        //    //To Select Country Name from Dropdown List
        //    getElement(By.XPath("//select[@name='country']/option[66]"),"").Click();

        //    //To Select Title from Dropdown List
        //    getElement(By.XPath("//select[@name='title']/option[10]"),"").Click();

        //    //To Write on Degree Name
        //    getElement(By.XPath("//input[@name='degree']"),"").SendKeys("Master Of Business Administration");

        //    //To Select Year of Gra from Dropdown List
        //    getElement(By.XPath("//select[@name='yearOfGraduation']/option[11]"),"").Click();

        //    //Identify the Add Button and clink on it
        //    getElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"),"").Click();

        //    Console.WriteLine("*************" + getSuccessMessagePopup().Text);
        //    Assert.AreEqual(getSuccessMessagePopup().Text, "");


        //    /////////////* To Edit and  Update Functionality on the Education */////////////////////

        //    //To Edit English the one of the language 
        //    getElement(By.XPath("//table[@class='ui fixed table']/tbody[2]/tr/td[6]/span[1]/i"), "Click on Expert Level Edit button on Education").Click();

        //    //Identify the AddLanguage Element and Add Text to it
        //    getElement(By.XPath("//div[@class='ten wide field']/input"), "Change the Value of Add text in Education").SendKeys("English11");

        //    //Identify the Update Element and Click on it
        //    getElement(By.XPath("//div[@class='sixteen wide field']/input[1]"), "Click on the Update").Click();

        //    Console.WriteLine("*************" + getSuccessMessagePopup().Text);
        //    Assert.AreEqual(getSuccessMessagePopup().Text, "");

        //    //////////////////* To Delete Operation on the Row in the Education *//////////////////

        //    //To Edit English the one of the language 
        //    getElement(By.XPath("//table[@class='ui fixed table']/tbody[2]/tr/td[6]/span[2]/i"), "Click on Expert Level Edit button on Education").Click();


        //    Console.WriteLine("*************" + getSuccessMessagePopup().Text);
        //    Assert.AreEqual(getSuccessMessagePopup().Text, "");


        //    endTestCase();

        //}

        ////Certifications
        //public static void Test_createAndVerifyCertifications()
        //{
        //    initializeDriver(browsesrName);
        //    LoginPage.performUserLogin(userName, password);


        //    //To Click on the Certifications button
        //    getElement(By.XPath("//form[@class='ui form']/div/a[4]"),"").Click();

        //    //To click on AddNew Button
        //    getElement(By.XPath("//div[@data-tab='fourth']//div[text()='Add New']"),"").Click();

        //    //To Enter Certificate or Award
        //    getElement(By.XPath("//input[@name='certificationName']"),"").SendKeys("ISTQB Certification");

        //    //To Enter Certified From Text Field
        //    getElement(By.XPath("//input[@name='certificationFrom']"),"").SendKeys("ISTQB UK");

        //    //To Select Year 
        //    getElement(By.XPath("//select[@name='certificationYear']/option[5]"),"").Click();

        //    //Identify the Add Button and Click on it
        //    getElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"),"").Click();

        //    //To Click on the Certifications button
        //    getElement(By.XPath("//form[@class='ui form']/div/a[4]"),"").Click();

        //    //To click on AddNew Button
        //    getElement(By.XPath("//div[@data-tab='fourth']//div[text()='Add New']"),"").Click();

        //    //To Enter Certificate or Award
        //    getElement(By.XPath("//input[@name='certificationName']"),"").SendKeys("Cloud Certification");

        //    //To Enter Certified From Text Field
        //    getElement(By.XPath("//input[@name='certificationFrom']"),"").SendKeys("Amazon Web Services");

        //    //To Select Year 
        //    getElement(By.XPath("//select[@name='certificationYear']/option[3]"),"").Click();

        //    //Identify the Add Button and Click on it
        //    getElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"),"").Click();


        //    Console.WriteLine("*************" + getSuccessMessagePopup().Text);
        //    Assert.AreEqual(getSuccessMessagePopup().Text, "");

        //    /////////////* To Edit and  Update Functionality on the Certifications */////////////////////

        //    //To Edit English the one of the language 
        //    getElement(By.XPath("//table[@class='ui fixed table']/tbody[2]/tr/td[4]/span[1]/i"), "Click on Expert Level Edit button on Education").Click();

        //    //Identify the AddLanguage Element and Add Text to it
        //    getElement(By.XPath("//table[@class='ui fixed table']/tbody[2]/tr/td/div/div/div/input[@placeholder='Certificate or Award']"), "Change the Value of Add text in Education").SendKeys("English11");

        //    //Identify the Update Element and Click on it
        //    getElement(By.XPath("//span[@class='buttons-wrapper']/input[1]"), "Click on the Update").Click();


        //    Console.WriteLine("*************" + getSuccessMessagePopup().Text);
        //    Assert.AreEqual(getSuccessMessagePopup().Text, "");

        //    //////////////////* To Delete Operation on the Row in the Certifications *//////////////////

        //    //To Edit English the one of the language 
        //    getElement(By.XPath("//table[@class='ui fixed table']/tbody[2]/tr/td[4]/span[2]/i"), "Click on Expert Level Edit button on Education").Click();

        //    Console.WriteLine("*************" + getSuccessMessagePopup().Text);
        //    Assert.AreEqual(getSuccessMessagePopup().Text, "");


        //    endTestCase();

        //}



//    }

//}
