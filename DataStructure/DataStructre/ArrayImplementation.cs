using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class ArrayImplementation
    {   
        private string[] mystocks;
        public ArrayImplementation(int Size)
        {
            mystocks = new string[Size];
        }

        /// <summary>
        /// Add value to Array
        /// </summary>
        /// <param name="index"  Index = Zero Based Index></param>
        /// <param name="values"> Assign Value at Index</param>
        public void AddItemToArrays(int index , string values)
        {
            /* 
             * 
             */
            if (mystocks.Count() >= index)
            {
                Console.WriteLine($"Error!! can't add item at  index{index} : Index Out of Range ");
            }
            mystocks[index] = values;
            Console.WriteLine($"Sucesfully assigned Value {values} at Index {index}");
        }

        public int SeachItem(string value)
        {
            int idx = -1;
            
            for(int i = 0; i< mystocks.Count(); i++)
            {
                if (mystocks[i].Equals(value))
                {
                    idx = i;
                    Console.WriteLine($"Found value {value} at Index {i}");
                    break;
                }

            }


            Console.WriteLine($"Sucesfully assigned Value {values} at Index {index}");
            return idx;
        }


    }
}
