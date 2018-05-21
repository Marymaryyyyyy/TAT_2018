using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Task_dev9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter login: ");
            string login = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();

            LoginPage loginPage = new LoginPage();
            loginPage.NewsPage(login, password);

            NewsPage newsPage = new NewsPage();
            newsPage.MessagesPage();
        }
    }
}
