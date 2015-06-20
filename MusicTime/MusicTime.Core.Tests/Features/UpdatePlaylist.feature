﻿Feature: Update Playlist
	In order to have my music organized
	As a user
	I want to be able to rename the properties of my playlists

Scenario: Update Playlist correctly
	Given I am login as 'user@mail.com'
	And I have the following playlist in my list
	| Field       | Property             |
	| Name        | My coding rock       |
	| Description | code like a Rockstar |
	When I update this playlist with the following information
	| Field       | Property           |
	| Name        | My coding music    |
	| Description | Rock for Rockstars |
	Then My playlist list should be as follows
	| Name            | Description        |
	| My coding music | Rock for Rockstars |
