using System;

namespace Task_dev_3
{
    /// <summary>
    ///Converter converts the number in other notation system.
    /// </summary>
    class Converter
    {
        private string convertedValue;

        /// <summary>
        /// ConvertTo converts the number in other notation system.
        /// </summary>
        /// <param name="number">input number</param>
        /// <param name="convertedToValue">new number notation</param>
        /// <returns>output number of the new notation system </returns>
        public string ConvertTo(int inputNumber, int convertedToValue)
        {
            do
            {
                int rest = inputNumber % convertedToValue;
                inputNumber = inputNumber / convertedToValue;
                convertedValue = ChooseSymbol(rest) + convertedValue;
            }
            while (inputNumber > 0);
            return convertedValue;
        }

        private char ChooseSymbol(int rest)
        {
            const string elements = "0123456789ABCDEFGHIJ";
            return elements[rest];
        }
    }
}