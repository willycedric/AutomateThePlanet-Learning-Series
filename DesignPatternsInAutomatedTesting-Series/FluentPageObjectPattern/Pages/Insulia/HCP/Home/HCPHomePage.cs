using System;
using FluentPageObjectPattern.Core;
using FluentPageObjectPattern.Pages.Insulia.HCP.Statistics;

namespace FluentPageObjectPattern.Pages.Insulia.HCP.Home
{
    class HCPHomePage:BaseFluentPageSingleton<HCPHomePage, HCPHomePageElementMap, HCPHomePageValidator>
    {
        public HCPHomePage GoToStatisticsPage()
        {
            Map.HCPStatisticsMenu.Click();
            return this as HCPHomePage;
        }

        public HCPHomePage GoToNotificationMenuPage()
        {
            Map.HCPNotificationMenu.Click();
            return this as HCPHomePage;
        }
    }
}
