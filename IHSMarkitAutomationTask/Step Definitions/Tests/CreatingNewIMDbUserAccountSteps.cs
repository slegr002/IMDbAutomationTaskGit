using FluentAssertions;
using IMDbAutomationTask.UI.Test.Pages;
using System;
using TechTalk.SpecFlow;

namespace IMDbAutomationTask.UI.Test.Step_Definitions
{
    [Binding]
    public class CreatingNewIMDbUserAccountSteps
    {
        private readonly IMDbCreateNewAccountPage iMDbCreateNewAccountPage = new IMDbCreateNewAccountPage();
        private readonly IMDbPagesHeader iMDbPagesHeader = new IMDbPagesHeader();
        private readonly IMDbSignInPage iMDbSignInPage = new IMDbSignInPage();

        [StepDefinition(@"I am in the Create New Account Page")]
        public void GivenIAmInTheCreateNewAccountPage()
        {
            //Clicks on the signIn button on the Home Page
            iMDbPagesHeader.PageHeaderSignInButton.Click();

            //Clicks on the 'Create a New Account' button
            iMDbSignInPage.CreateANewAccountButton.Click();

        }

        [StepDefinition(@"I fill out input fields with the user name '(.*)', email '(.*)', password '(.*)', reentered password '(.*)'")]
        public void WhenIFillinInputFieldsWithTheUserNameEmailPasswordReenteredPassword(string userName, string UserEmail, string userPassword, string userReEnterPassword)
        {
            //Verifies that the 'Create Account' page is displayed
            iMDbCreateNewAccountPage.CreateAccountPageFormTitle
                .Text
                .Contains("Create account")
                .Should()
                .BeTrue("because the title of the form should contain Create account");

            //Enter string in Name field
            iMDbCreateNewAccountPage.YourNameInputField.SendKeys("Sebastien Test");

            //Enter string in Email field
            iMDbCreateNewAccountPage.EmailInputField.SendKeys("slegr002@fiu.edu");

            //Enter string in Password field
            iMDbCreateNewAccountPage.PasswordInputField.SendKeys("Brasil_12");

            //Enter string in re-enter password field
            iMDbCreateNewAccountPage.ReEnterPasswordInputField.SendKeys("Brasil_12");            
        }

        [StepDefinition(@"Click the CreateYourIMDbAccount button")]
        public void WhenClickTheButton()
        {
            //Click on the 'Create your IMDb account' button
            iMDbCreateNewAccountPage.CreateYourIMBdAccountButton.Click();
        }

        [StepDefinition(@"A new user account is created with user name '(.*)', email '(.*)', password '(.*)', reentered password '(.*)'")]
        public void ThenANewUserAccountIsCreatedWithUserNameEmailPasswordReenteredPassword(string userName, string UserEmail, string userPassword, string userReEnterPassword)
        {
            ScenarioContext.Current.Pending();

        } 
    }
}
