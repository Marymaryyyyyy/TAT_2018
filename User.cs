using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_dev8
{
    public struct User
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        /// <summary>
        /// If Sex = 1 - man, Sex = 0 - woman.  
        /// </summary>
        public bool Sex { get; set; }
        public uint Age { get; set; }

        public override string ToString()
        {
            return FirstName + " " + Lastname + " " + Age + " " + Sex;
        }
    }


}




