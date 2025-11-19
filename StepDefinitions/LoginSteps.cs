// Steps/LoginSteps.cs
using Reqnroll;
using OpenQA.Selenium;
using FluentAssertions;

[Binding]
public class LoginSteps
{
    private IWebDriver _driver;
    private LoginPage _loginPage;
    /*
      [BeforeScenario]
      public void Setup()
      {
          _driver = WebDriverFactory.CreateEdgeDriver();
          _loginPage = new LoginPage(_driver);
      }

      [AfterScenario]
      public void TearDown()
      {
          _driver?.Quit();
      }

      [Given(@"I am on the login page")]
      public void GivenIAmOnTheLoginPage()
      {
          _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
      }

      [When(@"I login with username ""(.*)"" and password ""(.*)""")]
      public void WhenILoginWithUsernameAndPassword(string username, string password)
      {
          _loginPage.Login(username, password);
      }

      [Then(@"I should see the dashboard")]
      public void ThenIShouldSeeTheDashboard()
      {
          var dashboardTitle = _driver.FindElement(By.ClassName("title"));
          dashboardTitle.Text.Should().Be("Products");
      }
    */

    [Given(@"I am testing docker")]
    public void Iamtestingdocker()
    {
        Console.WriteLine("Docker-successfully landed at Docker step defination file");
      
    }


}
