Feature: Certifications
	In order to create Profile Page 
	As a Turn Up portal User
	I would like to Create, Update and Delete Certifications in Profile Page


Scenario: Add and verify Certificate
	Given I launch application
	When I am in loginpage
	And I can log into application with 'myfriendchowdari@gmail.com' and 'Kiran123abc'
	And I can navigate To Profile Page 
	And I can click on Certifications
	And I can Add data by clicking AddNew button
	Then I can verify success message 'ISTQB Certification has been added to your certification'
	

	Scenario: Update and verify certificate
	Given I launch application
	When I am in loginpage
	And I can log into application with 'myfriendchowdari@gmail.com' and 'Kiran123abc'
	And I can navigate To Profile Page 
	And I can click on Certifications
	And I can Edit and Update the Entiry
	Then I can verify success message 'ISTQB CertificationEnglish11 has been updated to your certification'


	Scenario:delete and verify certificate
	Given I launch application
	When I am in loginpage
	And I can log into application with 'myfriendchowdari@gmail.com' and 'Kiran123abc'
	And I can navigate To Profile Page 
	And I can click on Certifications
	And I can Delete the entiry
	Then I can verify success message 'Cloud Certification has been deleted from your certification'