using FluentAssertions;
using IMDbAutomationTask.UI.Test.Pages;
using TechTalk.SpecFlow;

namespace IMDbAutomationTask.UI.Test.Step_Definitions.Tests
{
    [Binding]
    public class WatchListRecordSortingSteps
    {
        IMDbPagesHeader iMDbPagesHeader = new IMDbPagesHeader();
        IMDbYourWatchListPage iMDbYourWatchListPage = new IMDbYourWatchListPage();

        [Given(@"I am on the movie Watchlist Page")]
        public void GivenIAmOnTheMovieWatchListPage()
        {
            //Clicks on the watchlist button
            iMDbPagesHeader.WatchListButton.Click();
        }
        [When(@"I sort the Watch list by '(.*)'")]
        public void WhenISortTheWatchListBy(string sortOptionName)
        {
            //Selects a sort option
            iMDbYourWatchListPage.SelectSortOption(sortOptionName).Click();
        }

        [Then(@"the List is successfully sorted by '(.*)'")]
        public void ThenTheListIsSuccessfullySortedBy(string sortOptionName)
        {
            //Verifies that the list is sorted correctly
            iMDbYourWatchListPage.VerifyWatchlistSorting(sortOptionName)
                .Should()
                .NotBeNull();
        }

    }
}
