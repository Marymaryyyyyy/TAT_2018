using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_dev_6.Interfaces;

namespace Task_dev_6.Implementations
{
    public class CountAll : ICommand
    {
        public double Command(List<Product> listOfProducts, string data)
        {
            return listOfProducts.Count();
        }
    }
}
