using System;

namespace Task_dev_3
{   
    /// <summary>
    /// This is the input point of the program.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            int number;
            int convertedToValue;

            if (args.Length > 2)
            {
                bool checkNumber = Int32.TryParse(args[0], out number);
                bool checkFormatBase = Int32.TryParse(args[1], out convertedToValue);
                bool checkIntervalBase = convertedToValue > 2 && convertedToValue < 20;

                if (checkNumber && checkFormatBase && checkIntervalBase)
                {
                    Converter converter = new Converter();
                    Console.WriteLine("Output: {0}", converter.ConvertTo(number, convertedToValue));
                }
                else
                {
                    Console.WriteLine("Error! Incorrect format of the input data!");
                }
            }
            else
                Console.WriteLine("Error! Incorrect format of the input data!");                 
        }
    }
}
