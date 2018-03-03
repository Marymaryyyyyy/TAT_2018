using System;

namespace Task_dev_1
{
    /// <summary>
    /// This class is looking for repeating symbols in a string.
    /// </summary>
    class RepeatingSymbols
    {
        private string inputString;

        public RepeatingSymbols(string args)
        {
            inputString = args;
        }

        /// <summary>
        /// This method finds the maximum number of identical symbols in the string
        /// </summary>
        /// <returns>This method returns number</returns>
        public int MaxNumberRepeatingSymbols()
        {
            int currentCount = 1;
            int maxCount = 1;

            for (int i = 0; i < inputString.Length - 1; i++)
            {
                if (inputString[i].Equals(inputString[i + 1]))
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
             }
            return maxCount;
        }
    }
}


