using IMDb.UI.TestFramework.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMDbAutomationTask.UI.Test.Pages
{
    class IMDbPagesHeader: BasePage
    {
        /// <summary>
        /// Finds element for the PageHeader SignIn button
        /// </summary>
        public IWebElement PageHeaderSignInButton =>
            this.LookUpElement(By.XPath("//*[@id='imdbHeader']//*[@class='ipc-button__text' and text()='Sign In']"));

        /// <summary>
        /// Finds the element for the PageHeader User Account button
        /// </summary>
        public IWebElement PageHeaderUserAccountButton =>
            this.LookUpElement(By.XPath("//*[@id='imdbHeader']//span[contains(@class, 'user-name')]"));
    }
}
