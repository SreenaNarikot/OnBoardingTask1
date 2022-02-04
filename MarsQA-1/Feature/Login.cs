using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
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
    class Login : Driver
    {
        ProfileRecord profileRecord = new ProfileRecord();
        HomePage homePage = new HomePage();

        [Given(@": I logged into the URL succsfully")]
        public void GivenILoggedIntoTheURLuccsfully()
        {

            Driver driver = new Driver();
            driver.Initialize();
            Driver.TurnOnWait();
            Driver.NavigateUrl();
            SignIn.Login();
        }

        [Given(@": I navigate to profilepage")]
        public void GivenINavigateToProfilepage()
        {
            
            homePage.GoToProfile(driver);
        }

        [When(@": I add new profile record")]
        public void WhenIAddNewProfileRecord()
        {
           
            profileRecord.createprofilerecord(driver);

        }

        [Then(@":The profile record should be added succsfully")]
        public void ThenTheProfileRecordShouldBeAddedSuccsfully()
        {
           
            string language = profileRecord.getlanguage(driver);
            Assert.That(language == "English", "Actual language and Expected do not match");
            string level = profileRecord.getlevel(driver);
            Assert.That(level == "Conversational", "Actual level and Expected level do not match");
        }
    }
}
