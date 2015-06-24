Feature: Create Playlist
	I order to get my prefer music ordered in one place
	As a user
	I want to be able to create a playlist

Scenario: Create a new playlist
	Given I have registered and login as 'user@mail.com'
	When I create a playlist with the following information
		| Field       | Value                |
		| Name        | My EDM               |
		| Description | My EDM for the world |
	Then My playlist list should be like follows
		| Name   | Description          |
		| My EDM | My EDM for the world |

Scenario: Create a new playlist without name
	Given I have registered and login as 'user@mail.com'
	When I create a playlist with the following information
		| Field       | Value                |
		| Name        |                      |
		| Description | My EDM for the world |  
	Then I should see an unsuccessful error message 'Name is required'

Scenario: Create a new playlist without description
	Given I have registered and login as 'user@mail.com'
	When I create a playlist with the following information
		| Field       | Value  |
		| Name        | My EDM |
		| Description |        |  
	Then I should see an unsuccessful error message 'Description is required'

