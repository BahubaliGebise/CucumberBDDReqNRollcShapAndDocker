// Drivers/WebDriverFactory.cs
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

public static class WebDriverFactory
{
    /*public static IWebDriver CreateEdgeDriver()
    {
        new DriverManager().SetUpDriver(new EdgeConfig());
        var options = new EdgeOptions();
        return new EdgeDriver(options);
    }  */

    public static IWebDriver CreateEdgeDriver()
    {
        var options = new EdgeOptions();

        var service = EdgeDriverService.CreateDefaultService(
            @"C:\Users\WebDriver\Edge",
            "msedgedriver.exe"
        );

        return new EdgeDriver(service, options);
    }

}