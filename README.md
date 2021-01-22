# IMDbAutomationTaskGit

# Required Tools
Visual Studio Professional 
SpecFlow Extension

# Nuget Packages
FluentAssertions (to assert results)

NUnit (To run the test in a .NET programming language)

NUnit3TestAdapter (To run the test in Visual Studio)

Selenium.Support (For browser automation)

Selenium.WebDriver (To send commands to browser)

SpecFlow (To run BDD style Gherkin based test scenario writing in Visual Studio)

SpecFlow.NUnit (To integrate Specflow with NUnit)

SpecFlow.Tools.MsBuild.Generation (To generate the code behind)

WebDriverManager (To download browser executables)

# Features Being tested:
SearchAndAddMovieToWatchList.feature

WatchListRecordSorting.feature

SignInToIMDbAccount.feature

CreatingNewIMDbUserAccount.feature -> Did not complete this test scenario because the site has a Captcha feature setup. 
Therefore, when attempting to create an account, the automation software would either need the development team to provide an environment  
This is to prevent hackers from crashing the server.

# Tasks
1. Author tests and utilities to create an imdb account and to log into https://imdb.com
  a. Make sure you can create an account via the Create New Account form.
2.Script tests and utilities that adds any media searched for onto the watch list.
  a. Verify that you can add and remove items from the watch list.
  b. Verify that every sort by type modifies the list correctly.
Automate one other piece of functionality of your choosing. Big or small.

### The tests can be executed from the Test Explorer in Visual Studio
### I had to tweek some of the locators because there were instances where the webdriver could not find elements. 
### But, it would be easier to discuss the code instead of me explaining in writing

Copyright© 2020 Sebastien Legros. All rights reserved 
