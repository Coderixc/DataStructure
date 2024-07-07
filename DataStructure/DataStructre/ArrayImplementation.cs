

namespace DataStructure
{
    internal class ArrayImplementation
    {
        #region SECTION: Declare and Array
        /*
         Declare an array by specifying the type of its elements followed by square brackets `[]`
         Initialization can be done at the time of declaration or later
         Array elements are accessed using their index(Zero Based Index)
         For Iterating : use `for` and `foreach` loop
         
         Arrays have a fixed size, which means that memory is allocated in advance.[No Allocation and Deallocation During Run Time]
         Arrays are stored in contiguous memory locations
         Arrays allow constant time access  O(1) to elements with the help of Index .This makes it very efficient to retrieve or update elements.
         */


        private string[] mystocks; //one-dimensional
        private string[,] mystocksWithPrice; //two-dimensional

        #endregion
        public ArrayImplementation(int Size)
        {  

            mystocks = new string[Size];
            mystocksWithPrice = new string[Size,2]; //Row [Size] , Coloumn [2]
        }

        public void SizeOfArray()
        {
            BackgroundColor.WriteInHighlight("Since arrays are objects in C#,\n" +
                "we can find their length using member length \n" +
                "** This is different from C/C++ where we find length using sizeof operator");

            Console.WriteLine($"Total Element in Array(1D) :{mystocks.Length}");

            Console.WriteLine($"Total Element in Array(2D) :{mystocksWithPrice.Length}");
            Console.WriteLine($"Rows in Array(2D) :{mystocksWithPrice.GetLength(0)}");
            Console.WriteLine($"Columns in Array(2D) :{mystocksWithPrice.GetLength(1)}");
        }

        /// <summary>
        /// Add value to Array
        /// </summary>
        /// <param name="index"  Index = Zero Based Index></param>
        /// <param name="values"> Assign Value at Index</param>
        public void AddorUpdateElementToArrays(int index , string values)
        {

            if (mystocks.Count() <= index)
            {
                Console.WriteLine($"Error!! can't add item at  index{index} : Index Out of Range ");
            }

            if (mystocks[index] is null) //Add Value
            {
                Console.WriteLine( $"Adding New Element {values} at Index {index}");
                mystocks[index] = values;
            }
            else             //Updating
            {
                Console.WriteLine($"Updating Element From {mystocks[index] } to {values} at Index {index}");
                mystocks[index] = values;
            }  
        }

        public void AddOrUpdateElementTo2Arrays(int Rowindex, string Stockname, string Stockvalue)
        {
            /* 
             * 10{ 0-9}     search  idx = 10
             */
            if (mystocksWithPrice.GetLength(0) <= Rowindex)
            {
                Console.WriteLine($"Error!! can't add item at  index{Rowindex} : Index Out of Range ");
            }
            if (mystocksWithPrice[Rowindex, 0] is null) //Add Value
            {
                mystocksWithPrice[Rowindex, 0] = Stockname;
                mystocksWithPrice[Rowindex, 1] = Stockvalue;
                Console.WriteLine($"Adding new element [{Stockname},{Stockvalue}] at Index {Rowindex}");
            }
            else //Updating
            {

                Console.WriteLine($"Updating element  From [{mystocksWithPrice[Rowindex, 0]} ,{mystocksWithPrice[Rowindex, 1]} to [{Stockname},{Stockvalue}]  at Index {Rowindex}");
                mystocksWithPrice[Rowindex, 0] = Stockname;
                mystocksWithPrice[Rowindex, 1] = Stockvalue;
            }
        }


        /// <summary>
        /// Linear Seach
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int SearchElementinArray(string value)
        {
            BackgroundColor.WriteInHighlight("Accessing array elements using for loop takes O(n)");
            int idx = -1;

            for(int i = 0; i< mystocks.Count(); i++)
            {
                if ( mystocks[i] != null && mystocks[i].Equals(value)  )
                {
                    idx = i;
                    Console.WriteLine($"Found value {value} at Index {i}");
                    break;
                }
            }
            if (idx == -1)
            {
                Console.WriteLine($"Not Found value {value}");
            }
            return idx;
        }

        public void PrintAllElementInArray()
        {
            foreach(var element in mystocks)
            {
                if (element is null) // Skip , if No element is Found in array
                    continue;
                Console.WriteLine($"Element in Array is :{element}");
            }
        }

        //public void InbuiltMethod()
        //{
        //    //How to use Count() Method?
        //    BackgroundColor.WriteInHighlight($"`Count() Method` ->Total Element is  {mystocks.Count()}");


        //    //How to use  Distinct() Method?
        //    var distElement = mystocks.Distinct();
        //    BackgroundColor.WriteInHighlight($"`Distinct() Method` ->Total Distinct Element is  {distElement.Count()} out of  {mystocks.Count()}");
        //}

        public void InbuiltMethod()
        {
            // Step 1: Use Count() Method
            // Count the total number of elements in the array
            BackgroundColor.WriteInHighlight($"`Count() Method` ->Total Element is  {mystocks.Count()}");

            // Step 2: Use Distinct() Method
            // Get the distinct elements in the array
            var distElement = mystocks.Distinct();

            // Count the distinct elements and display the result
            BackgroundColor.WriteInHighlight($"`Distinct() Method` ->Total Distinct Element is  {distElement.Count()} out of  {mystocks.Count()}");
        }


    }
}
