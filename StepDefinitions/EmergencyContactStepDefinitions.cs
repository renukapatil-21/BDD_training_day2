using System;
using TechTalk.SpecFlow;

namespace Day1_SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class EmergencyContactStepDefinitions
    {
        [Given(@"Given I have browser with login page")]
        public void GivenGivenIHaveBrowserWithLoginPage()
        {
            Console.WriteLine("..");
        }

        [When(@"I click on My Information")]
        public void WhenIClickOnMyInformation()
        {
            Console.WriteLine("..");
        }

        [When(@"I click on Emergency contacts")]
        public void WhenIClickOnEmergencyContacts()
        {
            Console.WriteLine("..");
        }

        [When(@"I click on Add")]
        public void WhenIClickOnAdd()
        {
            Console.WriteLine("..");
        }

        [When(@"I fill the Emergency contact details")]
        public void WhenIFillTheEmergencyContactDetails(Table table)
        {
            Console.WriteLine("..");
        }

        [When(@"I click on save")]
        public void WhenIClickOnSave()
        {
            Console.WriteLine("..");
        }

        [Then(@"I should to navigated to view emergency contacts and verify the contact")]
        public void ThenIShouldToNavigatedToViewEmergencyContactsAndVerifyTheContact()
        {
            Console.WriteLine("..");
        }
    }
}
