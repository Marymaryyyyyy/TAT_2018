using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_dev8.Commands
{

    public class OldestUserCommand : ICommand
    {       
        public void Execute(List<User> list)
        {
            uint maxAge = 0;

            foreach (var user in list)
            {
                if (maxAge < user.Age)
                {
                    maxAge = user.Age;
                }
            }

            var result = from oldestUser in list
                         where oldestUser.Age == maxAge
                         select oldestUser;

            foreach (var man in result)
            {
                Console.WriteLine(man.ToString());
            }
        }
    }
}