Feature: Add Song to Playlist
	In order to allow me to build my lovely playlists
	As an user
	I want to be able to add my favorite songs into my existing playlist

Scenario: Add song to a playlist
	Given the following song exists in the global library
			| Field       | Value                        |
			| Name        | A random song                |
			| Description | A song I wrote for the world |
			| StreamId    | 12345856_streamId_25         |
			| Genre       | Rock                         |
	And I am login as 'user@mail.com'
	And I have the following playlist in my list
			| Field       | Property             |
			| Name        | My coding music      |
			| Description | code like a Rockstar |
	When I search for the song with the name 'A random song'
	And add it to my 'My coding music' playlist
	Then songs in my 'My coding music' playlist should be as follow
		| Name          | Description                  | StreamId             | Genre |
		| A random song | A song I wrote for the world | 12345856_streamId_25 | Rock  |

