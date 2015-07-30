Feature: User Registration
	In order create my awesome playlists
	As an user
	I want to be able to create my account in MusicTime app

Scenario: Register new user
	When I register with the following info
	| Field    | Value          |
	| Email    | user@email.com |
	| Password | P@$$w0rd       |
	Then I should be logged in as 'user@email.com'
