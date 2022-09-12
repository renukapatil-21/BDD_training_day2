using Day1_SpecFlowProject1.Hooks;
using OpenQA.Selenium;
using System;
using System.Runtime.Versioning;
using TechTalk.SpecFlow;

namespace Day1_SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class EmployeeStepDefinitions
    {
        private string fName;

        [When(@"I click on PIM")]
        public void WhenIClickOnPIM()
        {
            AutomationHooks.driver.FindElement(By.XPath("//span[text()='PIM']")).Click();
        }

        [When(@"I click on Add Employee")]
        public void WhenIClickOnAddEmployee()
        {
            AutomationHooks.driver.FindElement(By.XPath("//a[text()='Add Employee']")).Click();
        }

        [When(@"I fill the add Employee section")]
        public void WhenIFillTheAddEMployeeSection(Table table)
        {
            string fName = table.Rows[0]["firstname"];
            string mName = table.Rows[0]["middlename"];
            string lName = table.Rows[0]["lastname"];
            string toggleLoginDetail = table.Rows[0]["toggle_login_detail"];
            string UserName = table.Rows[0]["username"];
            string password = table.Rows[0]["password"];
            string confirmPassword = table.Rows[0]["confirm_password"];
            string status = table.Rows[0]["status"];

            AutomationHooks.driver.FindElement(By.Name("firstName")).SendKeys(fName);
            AutomationHooks.driver.FindElement(By.Name("middleName")).SendKeys(mName);
            AutomationHooks.driver.FindElement(By.Name("lastName")).SendKeys(lName);


            if (toggleLoginDetail.Equals("on"))
            {
                AutomationHooks.driver.FindElement(By.XPath("//span[contains(@class, 'oxd-switch-input')]")).Click();

                AutomationHooks.driver.FindElement(By.XPath("//label[contains(text(), 'Username')]/following::input")).SendKeys(UserName);
                AutomationHooks.driver.FindElement(By.XPath("//label[contains(text(), 'Password')]/following::input")).SendKeys(password);
                AutomationHooks.driver.FindElement(By.XPath("//label[contains(text(), 'Confirm Password')]/following::input")).SendKeys(confirmPassword);

                if (status.ToLower().Equals("disabled"))
                {
                    AutomationHooks.driver.FindElement(By.XPath("//label[text()='Disabled']")).Click();
                }
                else
                {
                    AutomationHooks.driver.FindElement(By.XPath("//label[text()='Enabled']")).Click();
                }
            }

        }

        [When(@"I click on save employee")]
        public void WhenIClickOnSaveEmployee()
        {
            AutomationHooks.driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }

        [Then(@"I should to navigated to personal details section with added employee records")]
        public void ThenIShouldToNavigatedToPersonalDetailsSectionWithAddedEmployeeRecords()
        {
            string actualFirstName = AutomationHooks.driver.FindElement(By.Name("firstName")).GetAttribute("value");
            Assert.Equal(fName, actualFirstName);
        }
    }
}
