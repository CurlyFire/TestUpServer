using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace FullAcceptanceTests
{
    [Binding]
    public class TestSteps
    {
        private HomePageObject _homePage;

        public TestSteps(HomePageObject homePage)
        {
            _homePage = homePage;
        }

        [Given(@"I have opened the root page")]
        public void GivenIHaveOpenedTheRootPage()
        {
            
        }

        [When(@"I press about")]
        public void WhenIPressAbout()
        {
        }

        [Then(@"the result should be the about page")]
        public void ThenTheResultShouldBeTheAboutPage()
        {
        }
    }
}
