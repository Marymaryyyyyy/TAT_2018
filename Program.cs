using System;
 Task-dev_6
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_dev_6.Interfaces;
using Task_dev_6.Implementations;

namespace Task_dev_6
{

using System.Text;

namespace Task_Dev2
{
    /// <summary>
    /// This class is the entry point to the program
    /// </summary>
 master
    class EntryPoint
    {
        /// <summary>
        /// The entry point to the program
        /// </summary>
        static void Main()
        {
 Task-dev_6
           var products = new List<Product>();
           var key = new ConsoleKeyInfo();

            do
            {
                var product = new Product();

              try { 
               Console.WriteLine(" Input type of product");
                product.Type = Console.ReadLine();

                Console.WriteLine(" Input the name of product");
                product.Name = Console.ReadLine();

                Console.WriteLine(" Input the quontity");
                product.Quantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" Input the cost of one product");
                product.Cost = Convert.ToDecimal(Console.ReadLine());

                products.Add(product);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


                Console.WriteLine("\n Do you want continue to input products?");
               Console.WriteLine("Yes [A]|No[B]");
               key = Console.ReadKey();
           }
           while (key.Key != ConsoleKey.B);

            do
            {
                Console.WriteLine("\n Input command:" +                   
                    "\n1) count types\n" +
                    "2) count all\n" +
                    "3) average price (all types)\n" +
                    "4) average price (type)\n" +
                    "5) exit" );
                string data = Console.ReadLine();
                if(data=="5")
                {
                    return;
                }

                SwitchCommand(products,data);

                Console.WriteLine("\n Do you want continue to input commands?");
                Console.WriteLine("Yes [A]| No[B]");
                key = Console.ReadKey();
            }
            while (key.Key != ConsoleKey.B);

        }


        static void SwitchCommand(List<Product> products, string data)
        {           
            switch (data)
            {
                case "1":
                    Console.WriteLine(Invoker.Invoke(new CountTypes(), products, "count types"));
                    break;
                case "2":
                    Console.WriteLine(Invoker.Invoke(new CountAll(), products, "count all"));
                    break;
                case "3":
                    Console.WriteLine(Invoker.Invoke(new AveragePrice(), products, "average price"));
                    break;
                case "4":
                    Console.WriteLine("Input type: ");
                    var type = Console.ReadLine();
                    Console.WriteLine(Invoker.Invoke(new AveragePriceType(), products, type));
                    break;               
                    
             }
            

            Builder inputString = new Builder(Console.ReadLine());
            Console.WriteLine(inputString.FindSequenceOfEvenIndex());
 master
        }


    }
}
 Task-dev_6

master
