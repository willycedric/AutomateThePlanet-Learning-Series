Feature: HCP_Navigation
 HCP must be able to navigate through all the link the page available on the portal
	Email notifications to medical team 
	- Patient list 
	- Statistics
	- Notifications
	- Settings
	- Patient details	


 @BSC
Scenario: HCP_statistic_View
	Given I login as HCP
	And I navigate to statistics main menu 
	Then I am able to view the statistics page

@BSC
Scenario: HCP_notification_View
	Given I login as HCP
	And I navigate to notifiation main menu 
	Then I am able to view the notification page

@BSC
Scenario: HCP_Settings_View
	Given I login as HCP
	And I navigate to Settings main menu
	Then I am able to view Settings page