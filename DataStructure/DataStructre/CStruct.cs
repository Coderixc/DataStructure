
namespace DataStructure.Struct
{
    /*
    In C#, structure is defined using struct keyword. Using struct keyword one can define the
    structure consisting of different data types in it.    

    Struct is VALUE TYPE [it will Copy the value]
    */
    public struct Stock  //User-Defined Data Types
    {
        public string Name; 
        public double ClosePrice;
    }

    internal class Struct_Implement
    {
        //Create List<T>
        List<Stock> mystocklist;
        public Struct_Implement()
        {
            Console.WriteLine("Implement Struct Type ");
            this.mystocklist = new List<Stock>(); 
        }



        public void addStock_toMylist()
        {
            try
            {
                //Create Object and insert its Values
                Console.WriteLine($"Adding Stock to my List ");
                Stock s1 ;
                s1.Name = "TATAMOTOR";
                s1.ClosePrice = 989.5;
                this.mystocklist.Add(s1);

                Stock s2;
                s2.Name = "ADANIENT";
                s2.ClosePrice = 2892.3;
                this.mystocklist.Add(s2);

                Stock s3 ;
                s3.Name = "TATAPOWER";
                s3.ClosePrice = 401.05;
                this.mystocklist.Add(s3);

                Stock s4;
                s4.Name = "IRCTC";
                s4.ClosePrice = 987.00;
                this.mystocklist.Add(s4);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// copy Struct : from existence object
        /// </summary> index is Zero based Index
        /// <param name="index"></param>
        public void copyStructure(int index)
        {
            // Copy one structure object into another one
            // Syntax using ‘=’ (Assignment) operator
            Console.WriteLine("\n");
            Console.WriteLine("                ---                ");
            Console.WriteLine($" Copy values from another struct object ");
            if (this.mystocklist.Count() > index)
            {
                Stock s = this.mystocklist.ElementAt(index); //acess stock struct object using elementAt()


                //Print all Item value in s
                Console.WriteLine($"Stock is {s.Name} and its ClosePrice = {s.ClosePrice}");
            }
            else
            {
                Console.WriteLine($"no struct(items present in myStock List");
            }
        }

        public void DisplayAll()
        {
            try
            {
                Console.WriteLine("\n");
                Console.WriteLine("                ---                ");
                if (this.mystocklist.Any()== false)  // Check - if stocks is presnet in List
                {
                    Console.WriteLine("No Stocks Present in list");
                    return;
                }    

                foreach (Stock s in this.mystocklist)
                {
                    Console.WriteLine($"Stock is {s.Name} and its ClosePrice = {s.ClosePrice}");
                }
                Console.WriteLine("                ---                ");
                Console.WriteLine("All Stocks printed unsder list");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
