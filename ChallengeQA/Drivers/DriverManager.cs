using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
// using OpenQA.Selenium.Firefox;
// using OpenQA.Selenium.MSEdgeDriver;

namespace ChallengeQA.Drivers
{
    public static class DriverManager{
        
        private static IWebDriver _driver;

        public static IWebDriver GetDriver()
        {
            if(_driver == null){
                _driver = new ChromeDriver();
                _driver.Manage().Window.Maximize();
            }
            return _driver;
        }
        public static void CloseDriver(){
            _driver?.Quit();
            _driver = null;
        }
    }
}