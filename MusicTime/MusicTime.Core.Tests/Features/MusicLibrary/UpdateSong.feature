Feature: Update Song information
	In order to allow users to create their playlist
	As an admin
	I want to be able to update my song repository 

Scenario: Update a song
	Given I am login as 'admin@mail.com'
	And I have the 'Admin' role
	And the following song is in my library
		| Field       | Value                        |
		| Name        | My rock song                 |
		| Description | A song I wrote for the world |
		| StreamId    | 12345856_streamId_25         |
		| Genre       | Rock                         |
	When I update this song information as follows
		| Field       | Value                  |
		| Name        | My 90s song            |
		| Description | A song I wrote for you |
		| StreamId    | 12345856_streamId_57   |
		| Genre       | Salsa                  |
	Then the music library should be as follows
		| Name        | Description            | StreamId             | Genre |
		| My 90s song | A song I wrote for you | 12345856_streamId_57 | Salsa |


Scenario: Update a song without name
	Given I am login as 'admin@mail.com'
	And I have the 'Admin' role
	And the following song is in my library
		| Field       | Value                  |
		| Name        | My 90s song            |
		| Description | A song I wrote for you |
		| StreamId    | 12345856_streamId_57   |
		| Genre       | Salsa                  |
	When I update this song information as follows
		| Field       | Value                  |
		| Name        |                        |
		| Description | A song I wrote for you |
		| StreamId    | 12345856_streamId_57   |
		| Genre       | Salsa                  |
	Then I should see an unsuccessful error message 'Name is required'

Scenario: Update a song without description
	Given I am login as 'admin@mail.com'
	And I have the 'Admin' role
	And the following song is in my library
		| Field       | Value                  |
		| Name        | My 90s song            |
		| Description | A song I wrote for you |
		| StreamId    | 12345856_streamId_57   |
		| Genre       | Salsa                  |
	When I update this song information as follows
		| Field       | Value                |
		| Name        | My rock song         |
		| Description |                      |
		| StreamId    | 12345856_streamId_25 |
		| Genre       | Rock                 |
	Then I should see an unsuccessful error message 'Description is required'

Scenario: Update a song without stream id
	Given I am login as 'admin@mail.com'
	And I have the 'Admin' role
	And the following song is in my library
		| Field       | Value                  |
		| Name        | My 90s song            |
		| Description | A song I wrote for you |
		| StreamId    | 12345856_streamId_57   |
		| Genre       | Salsa                  |
	When I update this song information as follows
		| Field       | Value                        |
		| Name        | My rock song                 |
		| Description | A song I wrote for the world |
		| StreamId    |                              |
		| Genre       | Rock                         |
	Then I should see an unsuccessful error message 'StreamId is required'

	
Scenario: Update a song without genre
	Given I am login as 'admin@mail.com'
	And I have the 'Admin' role
	And the following song is in my library
		| Field       | Value                  |
		| Name        | My 90s song            |
		| Description | A song I wrote for you |
		| StreamId    | 12345856_streamId_57   |
		| Genre       | Salsa                  |
	When I update this song information as follows
		| Field       | Value                        |
		| Name        | My rock song                 |
		| Description | A song I wrote for the world |
		| StreamId    | 12345856_streamId_25         |
		| Genre       |                              |
	Then I should see an unsuccessful error message 'Genre is required'

Scenario: Update a song without being admin
	Given I am login as 'admin@mail.com'
	And I have the 'Admin' role
	And the following song is in my library
		| Field       | Value                  |
		| Name        | My 90s song            |
		| Description | A song I wrote for you |
		| StreamId    | 12345856_streamId_57   |
		| Genre       | Salsa                  |
	And my friend login as 'myfriend@mail.com'
	When he tries to update this song information as follows
		| Field       | Value                        |
		| Name        | My rock song                 |
		| Description | A song I wrote for the world |
		| StreamId    | 12345856_streamId_25         |
		| Genre       | Rock                         |
	Then I should recived an not authorized exception