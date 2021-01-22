using IMDb.UI.TestFramework.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMDbAutomationTask.UI.Test.Pages
{
    /// <summary>
    /// class that contains locators for the WatchList page
    /// </summary>
    class IMDbYourWatchListPage: BasePage
    {
        /// <summary>
        /// Finds the select element for the list sort by options
        /// </summary>
        public IWebElement SortByDropDown => this.LookUpElement(By.Id("lister-sort-by-options"));

        /// <summary>
        /// Finds option element from sort by option list
        /// </summary>
        /// <param name="sortOptionName"></param>
        /// <returns></returns>
        public IWebElement SelectSortOption(string sortOptionName ) => 
            this.LookUpElement(By.XPath("//select[@id='lister-sort-by-options']/option[@value='" + sortOptionName + "']"));

        /// <summary>
        /// Finds the div element wich is used to verify the selected sort option 
        /// </summary>
        public IWebElement VerifyWatchlistSorting(string sortOptionName) => 
            this.LookUpElement(By.XPath("//div[@class='lister-sort-order visible-xs' and contains(text(), 'Sorted by " + sortOptionName + "')]"));
    }
}
