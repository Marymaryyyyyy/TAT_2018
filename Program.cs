 using System;
 Task_dev8
using System.Collections.Generic;
using System.IO;
using Task_dev8.Commands;

namespace Task_dev8

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Task_dev9
 master
{
    class Program
    {
        static void Main(string[] args)
        {
 Task_dev8
            try
            {
                var users = new List<User>();
                var input = new UserCreator();
                
                do
                {
                    var user = new UserCreator();
                    Console.WriteLine("\nInput the information about user.");

                    Console.WriteLine("\n1) Input the first name:");
                    user.SetFirstName(Console.ReadLine());

                    Console.WriteLine("\n2) Input the lastname:");
                    user.SetLastname((Console.ReadLine()), users);

                    Console.WriteLine("\n3) Input the age:");
                    user.SetAge(Console.ReadLine());

                    Console.WriteLine("\n4) Input the sex:");
                    user.SetSex(Console.ReadLine());

                    users.Add(user.Build());

                    Console.WriteLine("\nFor continue input press a");
                } while (Console.ReadKey(true).KeyChar == 'a');

                var invoker = new InvokerCommand();
                invoker.SetCommand(new AverageAgeCommand());
                invoker.ExecuteCommand(users);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Enter login: ");
            string login = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();

            LoginPage loginPage = new LoginPage();
            loginPage.NewsPage(login, password);

            NewsPage newsPage = new NewsPage();
            newsPage.MessagesPage();
 master
        }

    }
}
