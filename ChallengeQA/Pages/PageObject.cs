using OpenQA.Selenium;
using ChallengeQA.Drivers;

namespace ChallengeQA.Pages
{
    public abstract class PageObject
    {
        protected IWebDriver Driver;

        protected PageObject(){

            Driver = DriverManager.GetDriver();
            
        }
    }
}