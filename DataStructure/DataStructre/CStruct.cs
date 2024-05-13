
namespace DataStructure.DataStructre
{

    public struct Stock  //User-Defined Data Types
    {
        /*
         In C#, structure is defined using struct keyword. Using struct keyword one can define the
        structure consisting of different data types in it.    

        Struct is VALUE TYPE [it will Copy the value]
         */
        public string Name; 
        public double ClosePrice;
    }

    internal class Struct_Implement
    {
        //Create List<T>
        List<Stock> stockList;
        public Struct_Implement()
        {
            Console.WriteLine("Implement Struct Type ");
            this.stockList = new List<Stock>(); 
        }

        public void Insert_toStocklist()
        {
            try
            {
                //Create Object and insert its Values

                Stock s1 ;
                s1.Name = "TATAMOTOR";
                s1.ClosePrice = 989.5;
                this.stockList.Add(s1);

                Stock s2;
                s2.Name = "ADANIENT";
                s2.ClosePrice = 2892.3;
                this.stockList.Add(s2);

                Stock s3 ;
                s3.Name = "TATAPOWER";
                s3.ClosePrice = 401.05;
                this.stockList.Add(s3);

                Stock s4;
                s4.Name = "IRCTC";
                s4.ClosePrice = 987.00;
                this.stockList.Add(s4);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void PrintAll()
        {
            try
            {
                if (this.stockList.Any()== false)  // Check - if stocks is presnet in List
                {
                    Console.WriteLine("No Stocks Present in list");
                    return;
                }    

                foreach (Stock s in this.stockList)
                {
                    Console.WriteLine($"Stocks is {s.Name} and its ClosePrice = {s.ClosePrice}");
                }
                Console.WriteLine("All Stocks printed unsder list");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
