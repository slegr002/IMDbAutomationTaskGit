using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace IMDb.UI.TestFramework.Helpers
{
    /// <summary>
    /// Help class with method to LookUpElement
    /// </summary>
    public class BasePage
    {
        /// <summary>
        /// Allow the configurable delay when waiting for an element
        /// </summary>
        public readonly WebDriverWait wait;

        /// <summary>
        /// Initializes a new instance of the BasePage class.
        /// </summary>
        public BasePage()
        {
            this.wait = new WebDriverWait(BrowserHelper.GetDriver, TimeSpan.FromSeconds(10))
            {
                PollingInterval = TimeSpan.FromMilliseconds(250),
            };
        }

        /// <summary>
        /// This method is called when a single web element is expected to be returned
        /// </summary>
        /// <param name="locator"></param>
        /// <returns></returns>
        public IWebElement LookUpElement(By locator)
        {
            return this.wait.Until(driver => BrowserHelper.GetDriver.FindElement(locator));
        }
    }
}
