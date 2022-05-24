using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using System;

namespace SpecFlowzrunner.Hooks
{
    [Binding]
    public  class Hook
    {

        public static IWebDriver Driver=null!;
        
        [BeforeScenario]
        public static void BeforeScenarioWithTag()
        {
            Driver = new ChromeDriver(); 
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            Driver.Quit();
        }
    }
}