﻿using OpenQA.Selenium;
using FluentPageObjectPattern.Core;
namespace FluentPageObjectPattern.Pages.Home
{
    class HomePageElementMap:BasePageElementMap
    {
        public IWebElement LoginField
        {
            get
            {
                return Browser.FindElement(By.Id("cphMain_cphMain_wpLogin_login_UserName"));
            }
        }

        public IWebElement PasswordField
        {
            get
            {
                return Browser.FindElement(By.Id("cphMain_cphMain_wpLogin_login_Password"));
            }
        }

        public IWebElement LoginButton
        {
            get
            {
                return Browser.FindElement(By.Id("cphMain_cphMain_wpLogin_login_btnLogin"));
            }
        }
    }
}