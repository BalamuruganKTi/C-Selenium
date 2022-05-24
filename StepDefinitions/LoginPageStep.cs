using System;
using System.Threading;
using OpenQA.Selenium;
using SpecFlowzrunner.Hooks;

namespace SpecFlowzrunner.StepDefinitions
{
    [Binding]
    public class LoginPageStep
    {
        public  readonly IWebDriver Driver=Hook.Driver;
        
        [Given(@"I navigate to facebook\.com")]
        public void GivenINavigateToFacebook_Com()
        {
            Driver.Url = "https://www.facebook.com";
            
        }

        [When(@"I enter username and password")]
        public void WhenIEnterUsernameAndPassword()
        {
            
        }

        [Then(@"I click login button")]
        public void ThenIClickLoginButton()
        {
            
        }

        [Then(@"I enter to homepage of facebook")]
        public void ThenIEnterToHomepageOfFacebook()
        {
            
        }

    }
}
