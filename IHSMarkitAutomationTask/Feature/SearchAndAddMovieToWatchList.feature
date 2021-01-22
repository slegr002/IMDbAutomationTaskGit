Feature: SearchAndAddMovieToWatchList
	As a IMDb User
	I Want to search and Add a movie to the watchlist

@Scenario1
Scenario: Search And Add Movie To WatchList
	Given I am in the Sign In page
	When I select to 'Sign in with IMDb'
		And I enter user email 'slegr002@fiu.edu'
		And I enter user password 'Test_123'
		And I click on the Sign In button
	When I want to search for a movie
		And I search for 'The Terminator' in the Search Bar
	Then The search has returned results for 'The Terminator' 
	When I click on a record for 'The Terminator'
		And Add to the Watchlist
	Then the Record was successfully added to the Watch list
		