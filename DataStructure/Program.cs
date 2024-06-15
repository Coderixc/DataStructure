
using DataStructure; //Use namespace

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quant ALgo Lab");
            Console.WriteLine("Learn Data Structure using C# ");
            //dsTask1Struct();
            dsTask2Arrays();




           Console.ReadKey();   



        }

        private static void dsTask1Struct()
        {
            Console.WriteLine("Prog 1 : Struct - User Defined Data Types ");
            Struct_Implement struct_Implement = new Struct_Implement();
            struct_Implement.addStock_toMylist();
            struct_Implement.DisplayAll();

            //Copy Item from One Struct to another
            // 3 as argument suiggest, we are looking for struct stock object at location index 3
            struct_Implement.copyStructure(3);
        }

        private static void dsTask2Arrays()
        {


            Console.WriteLine("Prog 2 : Implement Arrays  ");

            //NIFTY 50 STOCK LIST
            /* https://www.nseindia.com/products-services/indices-nifty50-index
            'ADANIENT','ADANIPORTS','APOLLOHOSP','ASIANPAINT','AXISBANK','BAJAJ-AUTO','BAJFINANCE',
            'BAJAJFINSV','BPCL','BHARTIARTL','BRITANNIA','CIPLA','COALINDIA','DIVISLAB','DRREDDY',
            'EICHERMOT','GRASIM','HCLTECH','HDFCBANK','HDFCLIFE','HEROMOTOCO','HINDALCO','HINDUNILVR',
            'ICICIBANK','ITC','INDUSINDBK','INFY','JSWSTEEL','KOTAKBANK','LTIM','LT','M&M','MARUTI','NTPC',
            'NESTLEIND','ONGC','POWERGRID','RELIANCE','SBILIFE','SHRIRAMFIN','SBIN','SUNPHARMA','TCS','TATACONSUM',
            'TATAMOTORS','TATASTEEL','TECHM','TITAN','ULTRACEMCO','WIPRO'
             */

            //Set the Size of Array
            int size = 50; 
            ArrayImplementation arryImplementation = new ArrayImplementation(size);
            arryImplementation.AddItemToArrays(0, "ADANIENT");
            arryImplementation.AddItemToArrays(1, "ADANIPORTS");
            arryImplementation.AddItemToArrays(2, "APOLLOHOSP");
            arryImplementation.AddItemToArrays(3, "ASIANPAINT");
            arryImplementation.AddItemToArrays(4, "AXISBANK");
            arryImplementation.AddItemToArrays(5, "BAJAJ-AUTO");
            arryImplementation.AddItemToArrays(6, "BAJFINANCE");





        }
    }
}