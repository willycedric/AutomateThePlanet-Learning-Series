using FluentPageObjectPattern;
using TechTalk.SpecFlow;
namespace FluentPageObjectPattern.Steps.HCP
{
    [Binding]
   public partial class HCPSteps
    {
        [Given(@"I login as HCP")]
        public void GivenILoginAsHCP()=>Pages.Home
                .HomePage
                .Instance
                    .Navigate()
                    .EnterUserLogin(userLogin:"wonder.hcp1@yopmail.com")
                    .EnterUserPassword(userPassword:"vol+2019")
                    .Login();              
        
        [Given(@"I navigate to statistics main menu")]
        public void GivenINavigateToStatisticsMainMenu()=> Pages.Insulia
                 .HCP
                 .Home
                 .HCPHomePage
                     .Instance
                     .GoToStatisticsPage();         
        
         
        [Then(@"I am able to view the statistics page")]
        public void ThenIAmAbleToViewTheStatisticsPage() =>Pages.Insulia
                .HCP
                .Statistics
                    .HCPStatisticsPage
                    .Instance
                        .Validate()
                        .IsStatisticPageDisplayed();
        

        [Given(@"I navigate to notifiation main menu")]
        public void GivenINavigateToNotifiationMainMenu()=>
        
            Pages
                 .Insulia
                 .HCP
                 .Home
                 .HCPHomePage
                     .Instance
                     .GoToNotificationMenuPage();
        
        [Then(@"I am able to view the notification page")]
        public void ThenIAmAbleToViewTheNotificationPage()
        {
            ScenarioContext.Current.Pending();
        }
        [Given(@"I navigate to Settings main menu")]
        public void GivenINavigateToSettingsMainMenu()
        {
            ScenarioContext.Current.Pending();
        }
        [Then(@"I am able to view Settings page")]
        public void ThenIAmAbleToViewSettingsPage()
        {
            ScenarioContext.Current.Pending();
        }





    }
}
