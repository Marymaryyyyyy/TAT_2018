using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_dev8.Commands
{   
    public class AverageAgeCommand : ICommand
    {        
        public void Execute(List<User> list)
        {
            double result = 0.0;
            foreach (var user in list)
            {
                result = list.Average(p => p.Age);
            }

            Console.WriteLine("Average age is: {0}", result);
        }
    }
}