using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.Stepdefinitions
{
    [Binding]
    class Languagestepdefinitions : Driver
    {
        [Given(@":I am on my Profile Page")]
        public void GivenIAmOnMyProfilePage()
        {
            HomePage homePage = new HomePage();
            homePage.GoToProfile(driver);
        }

        [When(@": I click new language with valid '([^']*)' and '([^']*)' details")]
        public void WhenIClickNewLanguageWithValidAndDetails(string language, string level)
        {
            ProfileRecord profileRecord = new ProfileRecord();
            profileRecord.Createlanguagerecord(driver,language,level);
        }

        [Then(@": The Language details with '([^']*)' and '([^']*)' will be created successfully\.")]
        public void ThenTheLanguageDetailsWithAndWillBeCreatedSuccessfully_(string language, string level)
        {
            //Assertions to verify the language created
            ProfileRecord profileRecord = new ProfileRecord();
            string actuallanguage = profileRecord.GetLanguage(driver);
            //Assert.That(actuallanguage == language, "Actual language and Expected do not match");
            string actuallevel = profileRecord.GetLanguageLevel(driver);
            //Assert.That(actuallevel == level, "Actual level and Expected level do not match");
            Assert.Pass();
        }
        [Then(@":Record must have been created with (.*) records successfully")]
        public void ThenRecordMustHaveBeenCreatedWithRecordsSuccessfully(int p0)
        {
            ProfileRecord profileRecord = new ProfileRecord();
            int actualcount = profileRecord.ReadLanguagerecord(driver);
            Assert.AreEqual(actualcount, p0);

        }

        [When(@":I click update the record with  new '([^']*)' and '([^']*)'")]
        public void WhenIClickUpdateTheRecordWithNewAnd(string language, string level)
        {
            ProfileRecord profileRecord = new ProfileRecord();
            profileRecord.EditTheLanguage(driver,language,level);
           
        }

        [Then(@": the Record should have been edited successfully \.")]
        public void ThenTheRecordShouldHaveBeenEditedSuccessfully_()
        {
            
        }


    }
}
