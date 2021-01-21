using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace IMDb.UI.TestFramework.Helpers
{
    public class BrowserHelper
    {
        public static IWebDriver driver;

        /// <summary>
        /// Gets the current instance of the web driver
        /// </summary>
        public static IWebDriver GetDriver
        {
            get { return driver; }
            set { }
        }

        /// <summary>
        /// Method to create the driver instance returned from the configuration
        /// </summary>
        public static void Init()
        {
            
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("start-maximized");
            option.AddArguments("--disable-gpu");
            //option.AddArguments("--headless");

            new DriverManager().SetUpDriver(new ChromeConfig());
            Console.WriteLine("Setup");
            driver = new ChromeDriver(option);
            driver.Navigate().GoToUrl("https://www.imdb.com/");
        }
    }
}
