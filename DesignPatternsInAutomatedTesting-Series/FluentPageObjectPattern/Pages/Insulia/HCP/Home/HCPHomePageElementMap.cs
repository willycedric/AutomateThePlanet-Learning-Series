using FluentPageObjectPattern.Core;
using OpenQA.Selenium;

namespace FluentPageObjectPattern.Pages.Insulia.HCP.Home
{
    class HCPHomePageElementMap: BasePageElementMap
    {
        public IWebElement PatientGrid
        {
            get
            {
                return Browser.FindElement(By.Id("gridPatients"));
            }
        }

        public IWebElement HCPStatisticsMenu
        {
            get
            {
                return Browser.FindElement(By.XPath("//*[@id='cphMain_topNavigation']/div/ul/li[2]/a/span"));
            }
        }

       public IWebElement HCPNotificationMenu
        {
            get
            {
                return Browser.FindElement(By.XPath("//*[@id='cphMain_topNavigation']/div/ul/li[3]/a/span[1]"));
            }
        }
    }
}
