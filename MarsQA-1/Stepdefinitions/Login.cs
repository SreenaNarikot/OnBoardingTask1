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
           
                HomePage homePage = new HomePage();
                homePage.GoToProfile(driver);
        }

        [When(@"I Click Addnew Language with valid details")]
        public void WhenIClickAddnewLanguageWithValidDetails()
        {
            ProfileRecord profileRecord = new ProfileRecord();
            profileRecord.Createlanguagerecord(driver);
        }

        [Then(@"Profile page is created successfully")]
        public void ThenProfilePageIsCreatedSuccessfully()
        {
            ProfileRecord profileRecord = new ProfileRecord();
            string language = profileRecord.Getlanguage(driver);
            Assert.That(language == "English", "Actual language and Expected do not match");
            string level = profileRecord.Getlevel(driver);
            Assert.That(level == "Conversational", "Actual level and Expected level do not match");
   
        }

    }
}
