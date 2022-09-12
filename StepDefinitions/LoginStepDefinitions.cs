using Day1_SpecFlowProject1.Hooks;
using Docker.DotNet.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using static System.Net.WebRequestMethods;

namespace Day1_SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"I have browser with orangehrm page")]
        public void GivenIHaveBrowserWithOrangehrmPage()
        {
            AutomationHooks.driver = new ChromeDriver();

            AutomationHooks.driver.Manage().Window.Maximize();

            AutomationHooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            AutomationHooks.driver.Url = "https://opensource-demo.orangehrmlive.com/";
            
        }

        [When(@"I enter username as '([^']*)'")]
        public void WhenIEnterUsernameAs(string username)
        {
            AutomationHooks.driver.FindElement(By.Name("username")).SendKeys(username);
        }

        [When(@"I enter password as '([^']*)'")]
        public void WhenIEnterPasswordAs(string password)
        {
            AutomationHooks.driver.FindElement(By.Name("password")).SendKeys(password);
        }

        [When(@"I click on login")]
        public void WhenIClickOnLogin()
        {
            AutomationHooks.driver.FindElement(By.CssSelector("button[type='submit']")).Click();
        }

        [Then(@"I should be navigate to '([^']*)' dashboard screen")]
        public void ThenIShouldBeNavigateToDashboardScreen(string expectedValue)
        {
            Console.WriteLine(expectedValue);
            AutomationHooks.driver.Quit();
        }
        [Then(@"I should get error page as '([^']*)'")]
        public void ThenIShouldGetErrorPageAs(string expectedError)
        {
            string actualError = AutomationHooks.driver.FindElement(By.CssSelector(".oxd-alert-content-text")).Text;
             Assert.Equal(expectedError, actualError);
            Console.WriteLine("expected error");
            AutomationHooks.driver.Quit();
        }

    }
}
