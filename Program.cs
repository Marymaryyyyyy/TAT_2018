using System;
using System.Text;

namespace Task_dev_2
{
    /// <summary>
    /// This class is the entry point to the program
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// The entry point to the program
        /// </summary>
        static void Main()
        {
            Builder inputString = new Builder(Console.ReadLine());
            Console.WriteLine(inputString.FindSequenceOfEvenIndex());
        }
    }
}
