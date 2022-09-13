using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace petshop.StepDefinitions
{
    [Binding]
    public class PetshopStepDefinitions
    {
        RestClient restclient;
        RestRequest request;
        RestResponse response;

        [Given(@"I have base url '([^']*)' and resource with petid '([^']*)'")]
        public void GivenIHaveBaseUrlAndResourceWithPetid(string baseUrl, string resourse)
        {
            restclient = new RestClient(baseUrl + resourse);
        }

        [When(@"I do the Get Request")]
        public void WhenIDoTheGetRequest()
        {
             request = new RestRequest();
             response = restclient.Execute(request);
        }

        [Then(@"I should get a response as (.*)")]
        public void ThenIShouldGetAResponseAs(int expectedResponseCode)
        {
            int actualStatusCode = (int)response.StatusCode;
            Assert.Equal(expectedResponseCode, actualStatusCode);
        }

        [Then(@"I should get the details of pet in json format")]
        public void ThenIShouldGetTheDetailsOfPetInJsonFormat()
        {
            
        }

        [Then(@"I should get a message as '([^']*)'")]
        public void ThenIShouldGetAMessageAs(string expectedmsg)
        {
            string actualmsg = response.Content;
            Assert.Equal(expectedmsg, actualmsg);
        }

        [Given(@"I need add api_key '([^']*)' in the header")]
        public void GivenINeedAddApi_KeyInTheHeader(string apiKey)
        {
           // RestClient.AddDefaultHeader("api_Key", apiKey);
        }

        [When(@"I do the delete request")]
        public void WhenIDoTheDeleteRequest()
        {
            request = new RestRequest("",Method.Delete);
            response = restclient.Execute(request);
        }

        [Then(@"I should get the response as (.*)")]
        public void ThenIShouldGetTheResponseAs(int expectedResponseCode)
        {
            int actualStatusCode = (int)response.StatusCode;
            Assert.Equal(expectedResponseCode, actualStatusCode);
        }
    }
}
