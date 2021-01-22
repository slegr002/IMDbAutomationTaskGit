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
        IMDbTitleOverviewPage iMDbTitleOverviewPage = new IMDbTitleOverviewPage();

        [StepDefinition(@"I want to search for a movie")]
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

        [StepDefinition(@"The search has returned results for '(.*)'")]
        public void ThenIAmAbleToSelect(string movieName)
        {
            //Asserts that the search returned results
            iMDbSuggestionSearchResult.MovieSearchResultRecords(movieName)
                .Text
                .Contains(movieName)
                .Should()
                .BeTrue("because there should be results returned for that movie");
        }

        [When(@"I click on a record for '(.*)'")]
        public void WhenISelectARecord(string movieName)
        {
            //Clicks on one movie record
            iMDbSuggestionSearchResult.MovieSearchResultRecords(movieName).Click();
        }

        [When(@"Add to the Watchlist")]
        public void WhenAddToTheWatchlist()
        {
            //Check the content of the Watch list Ribbon before the movie is added to the watch list
            iMDbTitleOverviewPage.WatchlistRibonWithNoMovie
                .GetAttribute("title")
                .Should()
                .Equals("Click to add to watchlist1");

            //Clicks on the Watch List Ribbon to add the movie
            iMDbTitleOverviewPage.WatchlistRibonWithNoMovie.Click();
        }

        [Then(@"the Record was successfully added to the Watch list")]
        public void ThenTheRecordIsAddedToTheWatchList()
        {
            

            //Asserts that the movie was added 
            iMDbTitleOverviewPage.WatchlistRibonWithMovie
                .GetAttribute("title")
                .Should()
                .Equals("Click to remove from watchlist");

        }

    }
}
