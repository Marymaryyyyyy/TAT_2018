using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_dev_6.Interfaces;

namespace Task_dev_6.Implementations
{
    public class AveragePriceType : ICommand
    {
        public double Command(List<Product> listOfProducts, string data)
        {
            var listOfOneType = listOfProducts.Where(product => product.Type == data);
            var listOfPrice = new List<decimal>();
            foreach (var a in listOfOneType)
            {
                listOfPrice.Add(a.Cost);
            }
            return (double)listOfPrice.Average();
        }
    }
}
