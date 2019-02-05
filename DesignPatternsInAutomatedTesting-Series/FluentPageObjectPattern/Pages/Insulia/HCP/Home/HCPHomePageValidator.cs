using FluentPageObjectPattern.Core;
using FluentAssertions;

namespace FluentPageObjectPattern.Pages.Insulia.HCP.Home
{
    class HCPHomePageValidator: BasePageValidator<HCPHomePage, HCPHomePageElementMap, HCPHomePageValidator>
    {
        public HCPHomePage IsPatientGridDisplayed()
        {
            Map.PatientGrid.Displayed.Should().Be(true);
            return PageInstance;
        }

    }
}
