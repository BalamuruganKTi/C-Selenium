
using OpenQA.Selenium;
using SpecFlowzrunner.Hooks;

namespace SpecFlowzrunner.PageObjjects
{
    public  class LoginPageObject
    {
        public IWebDriver Driver;

        public LoginPageObject()
        {
            Driver = Hook.Driver;
        }

    }
}
