using FluentAssertions;
using IMDbAutomationTask.UI.Test.Pages;
using System;
using TechTalk.SpecFlow;

namespace IMDbAutomationTask.UI.Test.Step_Definitions.Tests
{
    [Binding]
    public class SearchAndSelectAMovieSteps
    {

        IMDbPagesHeader iMDbPagesHeader = new IMDbPagesHeader();
        IMDbSuggestionSearchResult iMDbSuggestionSearchResult = new IMDbSuggestionSearchResult();

        [StepDefinition(@"I want to sear for a movie")]
        public void GivenIAmOnTheHomePage()
        {
            iMDbPagesHeader.PageHeaderSearchBar.Click();
        }
        
        [StepDefinition(@"I search for '(.*)' in the Search Bar")]
        public void WhenISearchForInTheSearchBar(string movieName)
        {
            //Searches based on User input
            
            iMDbPagesHeader.PageHeaderSearchBar.SendKeys(movieName);
            iMDbPagesHeader.PageHeaderSearchButton.Click();
        }

        [StepDefinition(@"I am able to Select '(.*)'")]
        public void ThenIAmAbleToSelect(string movvieName)
        {
            //Asserts that the search returned results
            iMDbSuggestionSearchResult.MovieSearchResult(movvieName)
                .Text
                .Contains(movvieName)
                .Should()
                .BeTrue("because there should be results returned for that movie");
        }
    }
}
