using FluentPageObjectPattern.Core;
using OpenQA.Selenium;

namespace FluentPageObjectPattern.Pages.Insulia.HCP.Statistics
{
    class HCPStatisticsPageElementMap:BasePageElementMap
    {
        public IWebElement StatisticPageTitle
        {
            get
            {
                return Browser.FindElement(By.Id("cphMain_cphWebParts_Stats_lblA1CTitleDistribution"));
            }
        }
    }
}
