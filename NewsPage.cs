using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Task_dev9
{
    class NewsPage
    {
        IWebDriver driver = new FirefoxDriver();
        public void MessagesPage()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            if (driver.Url != "https://vk.com/feed")
            {
                throw new Exception("This is not vk entrance page");
            }
            IWebElement element = driver.FindElement(By.XPath("//li[@id='l_msg']"));
            element.Click();
        }
    }
}
