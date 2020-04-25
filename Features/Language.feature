Feature: Language
	In order to create Profile Page 
	As a Turn Up portal User
	I would like to Create, Update and Delete Language in Profile Page


Scenario: Add and verify Languages
	Given I launch application
	When I am in loginpage
	And I can log into application with 'myfriendchowdari@gmail.com' and 'Kiran123abc'
	And I can navigate To Profile Page 
	And I can click on languages
	And I can Add data by clicking AddNew button on languages
	Then I can verify success Message 'Hindi has been added to your languages'

	
   Scenario: Update and verify Languages
	Given I launch application
	When I am in loginpage
	And I can log into application with 'myfriendchowdari@gmail.com' and 'Kiran123abc'
	And I can navigate To Profile Page 
	And I can click on languages
	And I can Edit and Update the Entiry in languages
	Then I can verify success Message 'EnglishEnglish11 has been updated to your languages'

	Scenario: Delete and verify Languages
	Given I launch application
	When I am in loginpage
	And I can log into application with 'myfriendchowdari@gmail.com' and 'Kiran123abc'
	And I can navigate To Profile Page 
	And I can click on languages
	And I can Deletw and Update the Entiry in languages
	Then I can verify Success Message 'Telugu has been deleted from your languages'