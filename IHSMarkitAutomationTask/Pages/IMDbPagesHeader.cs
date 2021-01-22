using IMDb.UI.TestFramework.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMDbAutomationTask.UI.Test.Pages
{
    /// <summary>
    /// class that contains locators for the Header page
    /// </summary>
    class IMDbPagesHeader : BasePage
    {
        /// <summary>
        /// Finds the input Element that represents the Suggestion Search Bar
        /// </summary>
        public IWebElement PageHeaderSearchBar => this.LookUpElement(By.Id("suggestion-search"));

        /// <summary>
        /// Finds the button Element that represents the Suggestion Search Bar
        /// </summary>
        public IWebElement PageHeaderSearchButton => this.LookUpElement(By.Id("suggestion-search-button"));

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

        /// <summary>
        /// Finds the div Element that represents the header watchlist button
        /// </summary>
        public IWebElement WatchListButton => 
            this.LookUpElement(By.XPath("//*[@id='imdbHeader']//div[contains(@class, 'watchlist-button')]"));
    }
}
