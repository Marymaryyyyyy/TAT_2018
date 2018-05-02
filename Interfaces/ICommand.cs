using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_dev_6.Interfaces
{
    public interface ICommand
    {
        double Command(List<Product> products, string data);

    }
}
