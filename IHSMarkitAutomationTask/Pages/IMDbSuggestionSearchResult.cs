using IMDb.UI.TestFramework.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMDbAutomationTask.UI.Test.Pages
{
    /// <summary>
    /// class that contains locators for the Search result page
    /// </summary>
    class IMDbSuggestionSearchResult : BasePage
    {
        /// <summary>
        /// Finds the link element that represents movie search result records
        /// </summary>
        /// <param name="movieTitle">parameter string for the title of a movies</param>
        /// <returns></returns>
        public IWebElement MovieSearchResultRecords(string movieTitle) => this.LookUpElement(By.XPath("//a[contains(text(),'" + movieTitle + "')]"));

        /// <summary>
        /// Finds the header element for the Search Result page header
        /// </summary>
        public IWebElement SearchResultPageHeader => this.LookUpElement(By.ClassName("findHeader"));
    }
}
