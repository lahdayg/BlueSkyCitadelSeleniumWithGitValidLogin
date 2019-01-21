using System;
using RCCG_Project.PageObjects;
using RCCG_Project.Utilities;
using TechTalk.SpecFlow;

namespace RCCG_Project.StepDefinition
{
    [Binding]
    public class LoginSteps

    {
        LoginClass1 loginclass1;

        public LoginSteps()
        {
            loginclass1 = new LoginClass1();
        }
        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Hooks.Driver.Navigate().GoToUrl("http://www.giftrete.com");
            Hooks.Driver.Manage().Window.Maximize();
        }
        
        [When(@"I when i click login")]
        public void WhenIWhenIClickLogin()
        {
            loginclass1.ClickLogin();
        }

        [When(@"I enter my email")]
        public void WhenIEnterMyEmail()
        {
            loginclass1.TypeEmail();
        }

        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            loginclass1.TypePassword();
        }

        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            loginclass1.ClickSignin();
        }



        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
