Feature: Remove Song From Playlist
	In order to maintain my playlist clean
	As a user
	I want to be able to remove songs

Scenario: Remove song from playlist
	Given I am login as 'user@mail.com'
	And I have the following playlist in my list
		| Field       | Property             |
		| Name        | My coding music      |
		| Description | code like a Rockstar |
	And 'My coding music' playlist has the following songs
		| Name                | Description                  | StreamId             | Genre    |
		| A random song       | A song I wrote for the world | 12345856_streamId_25 | Rock     |
		| Another random song | A song My brother wrote      | 15345856_streamId_27 | Salsa    |
		| Another song        | A song from my mom           | 15345856_streamId_29 | Acoustic |
	When I clicked to remove the song 'Another random song'
	Then songs in my 'My coding music' playlist should be as follow
         | Name                | Description                  | StreamId             | Genre    |
         | A random song       | A song I wrote for the world | 12345856_streamId_25 | Rock     |
         | Another song        | A song from my mom           | 15345856_streamId_29 | Acoustic |