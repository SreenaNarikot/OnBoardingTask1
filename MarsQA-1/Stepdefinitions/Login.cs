using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using MarsQA_1.Utils;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature 
{
    [Binding]
    class  Login : Driver
    {
 
        [Given(@"I am on my Profile Page")]
        public void GivenIAmOnMyProfilePage()
        {
                Thread.Sleep(3000);
                HomePage homePage = new HomePage();
                homePage.GoToProfile(driver);
            Thread.Sleep(3000);
        }

        [When(@"I Click Addnew Language with valid details")]
        public void WhenIClickAddnewLanguageWithValidDetails()
        {
            ProfileRecord profileRecord = new ProfileRecord();
            profileRecord.Createlanguagerecord(driver);
        }

        [When(@":I Click  Add new Skills with valid credentials")]
        public void WhenIClickAddNewSkillsWithValidCredentials()
        {
            ProfileRecord profileRecord = new ProfileRecord();
            profileRecord.Createskillsrecord(driver);
        }

        [When(@": I Click Add new Education with valid credentials")]
        public void WhenIClickAddNewEducationWithValidCredentials()
        {
            ProfileRecord profileRecord = new ProfileRecord();
            profileRecord.Createeducationtab(driver);
        }

        [When(@":I Click Andd new Certifications with valid credentials")]
        public void WhenIClickAnddNewCertificationsWithValidCredentials()
        {
            ProfileRecord profileRecord = new ProfileRecord();
            profileRecord.Createcertification(driver);
        }

        [Then(@"Profile page is created successfully")]
        public void ThenProfilePageIsCreatedSuccessfully()
        {
            //Assertions to verify the language created
            ProfileRecord profileRecord = new ProfileRecord();
            string language = profileRecord.Getlanguage(driver);
            Assert.That(language == "English", "Actual language and Expected do not match");
            string level = profileRecord.Getlevel(driver);
            Assert.That(level == "Conversational", "Actual level and Expected level do not match");

            //Assertions to verify the skills created
            string actualskill = profileRecord.GetSkill(driver);
            Assert.That(actualskill == "Chrochet", "Actual Skill and Expected skill do not match");
            string actualskilllevel = profileRecord.GetSkillLevel(driver);
            Assert.That(actualskilllevel == "Intermediate", "Actual Skill and Expected skill level do not match");

        }


    }
}
