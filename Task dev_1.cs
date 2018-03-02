using System;

namespace Task_dev_1
{
    /// <summary>
    /// This is the input point of the program.
    /// </summary>

    class EntryPoint
    {
        /// <summary>
        /// This is the input point of the program.
        /// </summary>
        /// <param name="args">String to input</param>
        static void Main(string[] args)
        {
            repeatingSymbols inputString = new repeatingSymbols(args[0]);
            Console.WriteLine(inputString.MaxNumberrepeatingSymbols());
            Console.ReadKey();
        }
    }
   
}

