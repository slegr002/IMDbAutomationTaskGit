using IMDb.UI.TestFramework.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMDbAutomationTask.UI.Test.Pages
{
    public class IMDbSignInPage: BasePage
    {
        /// <summary>
        /// Finds the element that represents for the list of Sign in options
        /// </summary>
        public IWebElement SigninPage => this.LookUpElement(By.XPath("//*[@id='signin-options']"));

        /// <summary>
        /// Finds the span element for the 'Sign in with IMDb' button 
        /// </summary>
        public IWebElement SignInWithIMDbButton =>
            this.LookUpElement(By.XPath("//*[@class='auth-provider-text' and text()='Sign in with IMDb']"));

        /// <summary>
        /// Finds element that represents the 'Create a New Account' button
        /// </summary>
        public IWebElement CreateANewAccountButton => this.LookUpElement(By.XPath("//*[contains(@class, 'create-account')]"));

        /// <summary>
        /// Finds the element for the 'Email' input field
        /// </summary>
        public IWebElement EmailInputField => this.LookUpElement(By.Id("ap_email"));

        /// <summary>
        /// Finds the element for the 'Password' input field
        /// </summary>
        public IWebElement PasswordInputField => this.LookUpElement(By.Id("ap_password"));

        /// <summary>
        /// Finds the element for the SignInSubmit button
        /// </summary>
        public IWebElement SignInSubmitButton => this.LookUpElement(By.Id("signInSubmit"));
    }
}
