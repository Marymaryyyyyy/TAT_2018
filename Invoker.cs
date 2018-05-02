using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_dev_6.Interfaces;


namespace Task_dev_6
{
    public class Invoker
    {
        public static double Invoke(ICommand chooseCommand, List<Product> products, string data)
        {
            return chooseCommand.Command(products, data);
        }
            
    }
}
