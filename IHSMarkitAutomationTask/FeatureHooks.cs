using IMDb.UI.TestFramework.Helpers;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace IMDbAutomationTask.UI.Test
{
    [Binding]
    public class FeatureHooks: BrowserHelper
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        /// <summary>
        /// Kills all chromedriver instances
        /// </summary>
        private static void KillChromeDriver()
        {
            foreach (var process in Process.GetProcessesByName("chromedriver"))
            {
                process.Kill();
            }
        }

        /// <summary>
        /// Setting up the Chrome browser options and navigating to home page 
        /// </summary>
        [BeforeScenario]
        public void BeforeScenario()
        {
            //Kill existing ChromeDriver instances
            KillChromeDriver();

            //Creates the Browser and lanches the browser
            Init();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
