using IMDb.UI.TestFramework.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMDbAutomationTask.UI.Test.Pages
{
    class IMDbSuggestionSearchResult: BasePage
    {
        /// <summary>
        /// Finds the link element that represents a movie search result record
        /// </summary>
        /// <param name="movieTitle">string for the title of a movies</param>
        /// <returns></returns>
        public IWebElement MovieSearchResult(string movieTitle) => this.LookUpElement(By.LinkText(movieTitle));

        /// <summary>
        /// Finds the header element for the Search Result page header
        /// </summary>
        public IWebElement SearchResultPageHeader => this.LookUpElement(By.ClassName("findHeader"));
    }
}
