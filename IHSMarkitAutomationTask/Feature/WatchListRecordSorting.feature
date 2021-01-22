Feature: WatchListRecordSorting
	As a IMDb User
	I want to be able to sort the movie watchlist

@Scenario1
Scenario: Sort Watch list records correctly
	Given I am in the Sign In page
		And I select to 'Sign in with IMDb'
		And I enter user email 'sebleg1001@gmail.com'
		And I enter user password 'Test_123'
		And I click on the Sign In button
		And I am on the movie Watchlist Page
#Select one of the sort values: LIST_ORDER, ALPHA, USER_RATING, MOVIEMETER, YOUR_RATING, NUM_VOTES, RELEASE_DATE, RUNTIME, DATE_ADDED
	When I sort the Watch list by 'USER_RATING'
#Select one of the Sort Options: Alphabetical, IMDb Rating, Popularity, Popularity, Your Rating, Number of Ratings, Release Date, Runtime, Date Added
	Then the List is successfully sorted by 'IMDb Rating'
