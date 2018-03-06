using System;

namespace Task_dev_3
{
    /// <summary>
    /// This class converts the number in other notation system.
    /// </summary>
    class Converter
    {
        private string convertedValue;            
        
        /// <summary>
        /// This class converts the number in other notation system.
        /// </summary>
        /// <param name="number">input number</param>
        /// <param name="convertedToValue">new number notation</param>
        /// <returns>output number of the new notation system </returns>
        public string ConvertTo(int number, int convertedToValue)
        {
            do
            {
                int rest = number % convertedToValue;
                number = number / convertedToValue;
                convertedValue = ChooseLetter(rest) + convertedValue;
            }
            while (number > 0);
            return convertedValue;
        }

        private char ChooseLetter(int rest)
        {
            string elements = "0123456789ABCDEFGHIJ";
            return elements[rest];
        }
    }
}
