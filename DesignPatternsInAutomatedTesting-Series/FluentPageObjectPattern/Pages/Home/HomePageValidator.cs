using FluentAssertions;
using NUnit.Framework;
using FluentPageObjectPattern.Core;

namespace FluentPageObjectPattern.Pages.Home
{
    class HomePageValidator: BasePageValidator<HomePage, HomePageElementMap, HomePageValidator>
    {
        public HomePage CheckHomeHeader(string expectedHeader)
        {
            Map.HomePageDescription.Text.ToLower().Should().Be(expectedHeader.ToLower());
            return PageInstance;
        }
    }
}
