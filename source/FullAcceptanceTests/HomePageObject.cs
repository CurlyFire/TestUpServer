using OpenQA.Selenium;

namespace FullAcceptanceTests
{
    public class HomePageObject
    {
        private IWebDriver _driver;

        public HomePageObject(IWebDriver driver)
        {
            _driver = driver;
        }
        public void NavigateToAbout()
        {

        }
    }
}
