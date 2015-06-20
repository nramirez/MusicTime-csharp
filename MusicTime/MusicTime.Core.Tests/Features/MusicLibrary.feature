Feature: Music Library
	In order to allow users to create their playlist
	As an admin
	I want to be able to provide them a repository of songs 

Scenario: Add new song
	Given I am login as 'admin@mail.com'
	And I have the 'Admin' role
	When I add a new song with the following information
	| Field       | Value                        |
	| Name        | My rock song                 |
	| Description | A song I wrote for the world |
	| StreamId    | 12345856_streamId_25         |
	| Genre       | Rock                         |
	Then the music library should be as follows
	| Name         | Description                  | StreamId             | Genre |
	| My rock song | A song I wrote for the world | 12345856_streamId_25 | Rock  |
