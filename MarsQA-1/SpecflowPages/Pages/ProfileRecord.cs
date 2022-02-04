using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    internal class ProfileRecord
    {
        public void createprofilerecord(IWebDriver driver )
        {
            //Identify the element Add new button and click on it
            IWebElement addNew = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNew.Click();
            //Identify the textboxbutton Addlanguage and enter the value
            IWebElement addLanguage = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addLanguage.SendKeys("French");
            //Identify the dropdown
            IWebElement chooseLanguagelevel = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            chooseLanguagelevel.Click();
            SelectElement selectElement = new SelectElement(chooseLanguagelevel);
            selectElement.SelectByIndex(2);
            IWebElement add = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            add.Click();

            //Identify the Skills tab and click on it
            IWebElement skills = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skills.Click();
            IWebElement addnewskills = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewskills.Click();
            //Find the textbox addskill and enter the value
            IWebElement addskilltextbox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            addskilltextbox.SendKeys("Chrochet");
            //Find the dropdown chooseskilllevel and select an option
            IWebElement chooseSkillLevel = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            chooseSkillLevel.Click();
            SelectElement selectskilllevel = new SelectElement(chooseSkillLevel);
            selectskilllevel.SelectByIndex(2);
            IWebElement addskill = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addskill.Click();

            //Identify the tab Education and click on it
            IWebElement educationtab = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationtab.Click();
            IWebElement addneweducation = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            addneweducation.Click();
            IWebElement universitytextbox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            universitytextbox.SendKeys("NTU");
            IWebElement countrydropdown = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            countrydropdown.Click();
            SelectElement countryofuniversity = new SelectElement(countrydropdown);
            countryofuniversity.SelectByText("Singapore");
            IWebElement titledropdown = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            titledropdown.Click();
            SelectElement title = new SelectElement(titledropdown);
            title.SelectByIndex(5);
            IWebElement degreetextbox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            degreetextbox.SendKeys("ComputerEngineering");
            IWebElement yearofgraduationdropdown = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            yearofgraduationdropdown.Click();
            SelectElement yearofgraduation = new SelectElement(yearofgraduationdropdown);
            yearofgraduation.SelectByValue("2006");
            IWebElement addeducation = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            addeducation.Click();

            //Identify the tap certification and click on it
            IWebElement certificationTab = driver.FindElement(By.XPath("//*[@id=account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationTab.Click();
            IWebElement addnewCertification = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addnewCertification.Click();
            IWebElement certificationtextbox = driver.FindElement(By.XPath("//*[@id=account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            certificationtextbox.SendKeys("Advanced Diploma");
            IWebElement certifiedFromTextBox = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            certifiedFromTextBox.SendKeys("TPE");
            IWebElement yeardropdown = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
            yeardropdown.Click();
            SelectElement year = new SelectElement(yeardropdown);
            year.SelectByValue("2010");
            IWebElement addcert = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            addcert.Click();
        }
        public string getlanguage(IWebDriver driver)
        {

            IWebElement language = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return language.Text;
        }
        public string getlevel(IWebDriver driver)
        {
            IWebElement level = driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            return level.Text;
        }
    }
}
