Feature: Education
	In order to create Profile Page 
	As a Turn Up portal User
	I would like to Create, Update and Delete Education in Profile Page

Scenario: Add and verify Education details
	Given I launch application
	When I am in loginpage
	And I can log into application with 'myfriendchowdari@gmail.com' and 'Kiran123abc'
	And I can navigate To Profile Page 
	And I can click on education
	And I can Add Data by clicking AddNew button on Education
	Then I can verify success Message 'Education has been added'
	

	Scenario: Update and verify Education
	Given I launch application
	When I am in loginpage
	And I can log into application with 'myfriendchowdari@gmail.com' and 'Kiran123abc'
	And I can navigate To Profile Page 
	And I can click on education
	And I can Edit and update the Entiry in Education
	Then I can verify success Message 'Education as been updated'


	Scenario: Delete and verify certificate
	Given I launch application
	When I am in loginpage
	And I can log into application with 'myfriendchowdari@gmail.com' and 'Kiran123abc'
	And I can navigate To Profile Page 
	And I can click on education
	And I can delete the entiry from Education
	Then I can verify success Message 'Education entry successfully removed'