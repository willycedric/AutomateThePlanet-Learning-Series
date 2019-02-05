using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentPageObjectPattern.Core;
using FluentPageObjectPattern.Pages.Login;

namespace FluentPageObjectPattern.Pages.Home
{
    class HomePage: BaseFluentPageSingleton<HomePage, HomePageElementMap, HomePageValidator>
    {
        public LoginPage Logout()
        {
            Map.HomepageLogOutLink.Click();
            return new LoginPage();
        }
    }
}
