﻿using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    internal class HomePage
    {
        public void GoToProfile(IWebDriver driver)
        {
            Thread.Sleep(6000);
            //Identify the element profile tab and click on it
            IWebElement profile = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]"));
            Thread.Sleep(3000);
            profile.Click();                                   
        }

    }
}
