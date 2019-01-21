﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RCCG_Project.Utilities;

namespace RCCG_Project.PageObjects
{
   public class LoginClass1
    {
        public LoginClass1()
        {
            PageFactory.InitElements(Hooks.Driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Login")]
        private IWebElement login;

        public void ClickLogin()

        {
            login.Click();
        }

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailElement;

        public void TypeEmail()
        {
            emailElement.SendKeys("test@test.com");
        }

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement passwordElement;

        public void TypePassword()
        {
            passwordElement.SendKeys("myPasswordisSecure");
        }

        [FindsBy(How = How.CssSelector, Using = "#login-form > div.buttons-holder.text-center > button")]
        private IWebElement signin;

        public void ClickSignin()
        {
            signin.Click();
        }





    }
}
