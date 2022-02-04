using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
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
            HomePage homePage = new HomePage();
        }

        [When(@": I add new profile record")]
        public void WhenIAddNewProfileRecord()
        {
            //throw new PendingStepException();
        }

        [Then(@":The profile record should be added succsfully")]
        public void ThenTheProfileRecordShouldBeAddedSuccsfully()
        {
            //throw new PendingStepException();
        }
    }
}
