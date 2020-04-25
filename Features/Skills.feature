Feature:Skills
	In order to create Profile Page 
	As a Turn Up portal User
	I would like to Create, Update and Delete Skills in Profile Page

Scenario: Add and verify Skills
	Given I launch application
	When I am in loginpage
	And I can log into application with 'myfriendchowdari@gmail.com' and 'Kiran123abc'
	And I can navigate To Profile Page 
	And I can click on skills
	And I can Add data by clicking AddNew button in skills
	Then I can verify success Message 'Cloud has been added to your skills'


	Scenario: Update and verify Skills
	Given I launch application
	When I am in loginpage
	And I can log into application with 'myfriendchowdari@gmail.com' and 'Kiran123abc'
	And I can navigate To Profile Page 
	And I can click on skills
	And I can Edit and Update the Entiry in skills
	Then I can verify success Message 'ISTQBScrum11 has been updated to your skills'


	Scenario: Delete and verify Skills
	Given I launch application
	When I am in loginpage
	And I can log into application with 'myfriendchowdari@gmail.com' and 'Kiran123abc'
	And I can navigate To Profile Page 
	And I can click on skills
	And I can Delete the entiry in skills
	Then I can Verify Success Message 'Scrum has been deleted'