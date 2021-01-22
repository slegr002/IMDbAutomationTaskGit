using FluentAssertions;
using IMDbAutomationTask.UI.Test.Pages;
using System;
using TechTalk.SpecFlow;

namespace IMDbAutomationTask.UI.Test.Step_Definitions.Tests
{
    [Binding]
    public class SignInToIMDbAccountSteps
    {
        private readonly IMDbSignInPage iMDbSignInPage = new IMDbSignInPage();
        private readonly IMDbPagesHeader iMDbPagesHeader = new IMDbPagesHeader();

        [StepDefinition(@"I am in the Sign In page")]
        public void GivenIAmInTheCreateSignInPage()
        {
            //Navigates to the Sign In page
            iMDbPagesHeader.PageHeaderSignInButton.Click();
        }

        [StepDefinition(@"I select to '(.*)'")]
        public void WhenISelectTo(string signInMethod)
        {
            //Clicks on the 'Sign In With IMDb' button              
            iMDbSignInPage.SignInWithIMDbButton(signInMethod).Click();
        }

        [StepDefinition(@"I enter user email '(.*)'")]
        public void WhenIEnterUserEmail(string userName)
        {
            //Enter string in Email field
            iMDbSignInPage.EmailInputField.SendKeys(userName);
        }

        [StepDefinition(@"I enter user password '(.*)'")]
        public void WhenIEnterUserPassword(string password)
        {
            //Enter string in password field 
            iMDbSignInPage.PasswordInputField.SendKeys(password);
        }

        [StepDefinition(@"I click on the Sign In button")]
        public void WhenIClickOnTheSignInButton()
        {
            //Clicks on the SignInSubmit button
            iMDbSignInPage.SignInSubmitButton.Click();
        }

        [StepDefinition(@"I'm signed in to user account for '(.*)'")]
        public void ThenIMSignedInToMyUserAccount(string userName)
        {
            //Verify that the user is signed in successfully
            iMDbPagesHeader.PageHeaderUserAccountButton
                .Text
                .Equals("Sebastien")
                .Should()
                .BeTrue("because the string Sebastien should displayed o the User Account button");
        }
    }
}
