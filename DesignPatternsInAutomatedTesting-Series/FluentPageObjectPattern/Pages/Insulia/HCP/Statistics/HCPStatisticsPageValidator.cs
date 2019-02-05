using FluentPageObjectPattern.Core;
using FluentAssertions;

namespace FluentPageObjectPattern.Pages.Insulia.HCP.Statistics
{
    class HCPStatisticsPageValidator: BasePageValidator<HCPStatisticsPage, HCPStatisticsPageElementMap, HCPStatisticsPageValidator>
    {
        public HCPStatisticsPage IsStatisticPageDisplayed()
        {
            Map.StatisticPageTitle.Displayed.Should().Be(true);
            return PageInstance;
        }
    }
}
