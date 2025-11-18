// Pages/LoginPage.cs
using OpenQA.Selenium;

public class LoginPage
{
    private readonly IWebDriver _driver;
    public LoginPage(IWebDriver driver) => _driver = driver;

    public IWebElement Username => _driver.FindElement(By.Id("user-name"));
    public IWebElement Password => _driver.FindElement(By.Id("password"));
    public IWebElement LoginButton => _driver.FindElement(By.Id("login-button"));


    public void Login(string username, string password)
    {
        Username.SendKeys(username);
        Password.SendKeys(password);
        LoginButton.Click();
    }
}
