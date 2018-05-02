using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_dev_6.Interfaces;

namespace Task_dev_6.Implementations
{
   public class AveragePrice : ICommand  
    {
        public double Command(List<Product> listOfProducts, string data)
        {
            List<decimal> list = new List<decimal>();
            foreach (var a in listOfProducts)
            {
                list.Add(a.Cost);
            }
            return (double)list.Average();
        }
    }
}
