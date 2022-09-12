using OpenQA.Selenium;

namespace Day1_SpecFlowProject1.Hooks
{
    [Binding]

    public class AutomationHooks
    {
        public static IWebDriver driver;

        [AfterScenario]
        public void EndScenario()
        {
            if(driver != null)
            {
                driver.Quit();
            }
        }

    }
}
