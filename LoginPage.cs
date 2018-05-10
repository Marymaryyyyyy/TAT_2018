using System;
using System.Collections.Generic;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Task_dev9
{
    class LoginPage
    {
        IWebDriver driver = new FirefoxDriver();
        public void NewsPage(string login, string password)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://vk.com/";
            if (driver.Url != "https://vk.com/")
            {
                throw new Exception("This is not vk entrance page");
            }
            driver.FindElement(By.Id("index_email")).SendKeys(login);
            driver.FindElement(By.Id("index_pass")).SendKeys(password + Keys.Enter);
        }
    }
}
