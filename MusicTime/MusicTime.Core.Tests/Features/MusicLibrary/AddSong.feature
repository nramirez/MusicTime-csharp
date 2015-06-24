Feature: Add Song in the music library
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


Scenario: Add new song without name
	Given I am login as 'admin@mail.com'
	And I have the 'Admin' role
	When I add a new song with the following information
	| Field       | Value                        |
	| Name        |                              |
	| Description | A song I wrote for the world |
	| StreamId    | 12345856_streamId_25         |
	| Genre       | Rock                         |
	Then I should see an unsuccessful add song error message 'Name is required'

Scenario: Add new song without description
	Given I am login as 'admin@mail.com'
	And I have the 'Admin' role
	When I add a new song with the following information
	| Field       | Value        |
	| Name        | My rock song |
	| Description |              |
	| StreamId    | 12345856_streamId_25         |
	| Genre       | Rock                         |
	Then I should see an unsuccessful add song error message 'Description is required'

Scenario: Add new song without stream id
	Given I am login as 'admin@mail.com'
	And I have the 'Admin' role
	When I add a new song with the following information
	| Field       | Value                        |
	| Name        | My rock song                 |
	| Description | A song I wrote for the world |
	| StreamId    |                              |
	| Genre       | Rock                         |
	Then I should see an unsuccessful add song error message 'StreamId is required'

	
Scenario: Add new song without genre
	Given I am login as 'admin@mail.com'
	And I have the 'Admin' role
	When I add a new song with the following information
	| Field       | Value                        |
	| Name        | My rock song                 |
	| Description | A song I wrote for the world |
	| StreamId    | 12345856_streamId_25         |
	| Genre       |                              |
	Then I should see an unsuccessful add song error message 'Genre is required'

Scenario: Add a song without being admin
	Given I am login as 'user@mail.com'
	When I add a new song with the following information
	| Field       | Value                        |
	| Name        | My rock song                 |
	| Description | A song I wrote for the world |
	| StreamId    | 12345856_streamId_25         |
	| Genre       | Rock                         |
	Then I should recived an not authorized exception