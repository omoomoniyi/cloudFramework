using OpenQA.Selenium;

namespace LoginPage.Pages
{
    public class LoginPage
    {

        private IWebDriver _driver;

        private IWebElement username => _driver.FindElement(By.XPath(""));

        private IWebElement password => _driver.FindElement(By.XPath(""));
        
        private IWebElement loginButton => _driver.FindElement(By.XPath(""));
       

    }



}
