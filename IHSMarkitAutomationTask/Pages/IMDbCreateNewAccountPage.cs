using IMDb.UI.TestFramework.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMDbAutomationTask.UI.Test.Pages
{
    class IMDbCreateNewAccountPage: BasePage
    {
        /// <summary>
        /// Finds the element that represents the wrapper div for the 'Create Account' form
        /// </summary>
        public IWebElement CreateAccountPageFormTitle => this.LookUpElement(By.ClassName("a-spacing-small"));

        /// <summary>
        /// Finds the element for the 'Your name' input field
        /// </summary>
        public IWebElement YourNameInputField => this.LookUpElement(By.Id("ap_customer_name"));

        /// <summary>
        /// Finds the element for the 'Email' input field
        /// </summary>
        public IWebElement EmailInputField => this.LookUpElement(By.Id("ap_email"));

        /// <summary>
        /// Finds the element for the 'Password' input field
        /// </summary>
        public IWebElement PasswordInputField => this.LookUpElement(By.Id("ap_password"));

        /// <summary>
        /// Finds the element for the 'Re-enter password' input field
        /// </summary>
        public IWebElement ReEnterPasswordInputField => this.LookUpElement(By.Id("ap_password_check"));

        /// <summary>
        /// Finds the element for the 'Create your IMBd account' input buttom to submit the form
        /// </summary>
        public IWebElement CreateYourIMBdAccountButton => this.LookUpElement(By.Id("continue"));
    }
}
