using System;
using System.Text;

namespace Task_Dev2
{
    /// <summary>
    /// This class finds in the string symbols with even indices
    /// </summary>
    public class Builder
    {
        private string inputString;

        public Builder(string line)
        {
            inputString = line;
        }

        /// <summary>
        /// This method builds the sequence of even indices
        /// </summary>
        /// <returns>Returns the sequence of even indices</returns>
        public string FindSequenceOfEvenIndex()
        {
            {
                StringBuilder sequenceOfEvenIndex = new StringBuilder(inputString);

                for (int i = 1; i < sequenceOfEvenIndex.Length; i++)
                {
                    sequenceOfEvenIndex.Remove(i, 1);
                }

                return sequenceOfEvenIndex.ToString();
            }
        }
    }
}
