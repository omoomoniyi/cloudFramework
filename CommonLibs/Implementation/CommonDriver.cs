using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace CommonLibs.Implementation
{

    public class CommonDriver
    {

        public IWebDriver Driver{get; private set;}
        public int PageLoadTimeout { private get => pageLoadTimeout; set => pageLoadTimeout = value; }
        public int ElementDetectionTimeout { private get => elementDetectionTimeout; set => elementDetectionTimeout = value; }

        private int pageLoadTimeout;

        private int elementDetectionTimeout;

        public CommonDriver(string browserType)
        {
            browserType = browserType.TrimEnd();

            pageLoadTimeout = 60;
            elementDetectionTimeout = 10;

            if (browserType.Equals("chrome")) {
                Driver = new ChromeDriver();
            }else if(browserType.Equals("edge"))
            {
                Driver = new EdgeDriver();
            }else {
                throw new Exception("Invalide Browser Type" + browserType);
            }
        }

        public void NavigateToFirstURL(string url){
                url = url.Trim();

                Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadTimeout);

                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(elementDetectionTimeout);

                Driver.Url = url;

        }
        

    }

}