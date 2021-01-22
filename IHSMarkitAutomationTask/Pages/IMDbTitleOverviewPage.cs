using IMDb.UI.TestFramework.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMDbAutomationTask.UI.Test.Pages
{
    /// <summary>
    /// class that contains locators for the Title Overview page
    /// </summary>
    class IMDbTitleOverviewPage : BasePage
    {
        /// <summary>
        /// Finds the h1 element for the movie title in the title bar 
        /// </summary>
        public IWebElement MovieTitle => this.LookUpElement(By.XPath("//div[@class='title_wrapper']/h1"));

        /// <summary>
        /// Finds Element used to verify if the movie is not yet added to the watch list
        /// </summary>
        public IWebElement WatchlistRibonWithNoMovie => this.LookUpElement(By.CssSelector("div[class='wl-ribbon standalone not-inWL']"));


        /// <summary>
        /// Finds Element used to verify if the movie was added to the watch list
        /// </summary>
        public IWebElement WatchlistRibonWithMovie => this.LookUpElement(By.CssSelector("div[class='wl-ribbon standalone inWL']"));
    }
}
