
using DataStructure; //Use namespace

namespace LinkedInPost
{
    internal class Program
    {
        static void Main(string[] args)
        {
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


            Console.WriteLine("Prog 2 : Implement Arrays in C# ");

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
            int size = 50; //Nifty 50 Bucket contains 50 Stocks
            ArrayImplementation arryImplementation = new ArrayImplementation(size);
            arryImplementation.SizeOfArray();

            BackgroundColor.WriteInHighlight("      ---One-Dimensional Array---", ConsoleColor.Red);

            //Add item to Array (One By one)
            arryImplementation.AddorUpdateElementToArrays(0, "ADANIENT");
            arryImplementation.AddorUpdateElementToArrays(1, "ADANIPORTS");
            arryImplementation.AddorUpdateElementToArrays(2, "APOLLOHOSP");
            arryImplementation.AddorUpdateElementToArrays(3, "ASIANPAINT");
            arryImplementation.AddorUpdateElementToArrays(4, "AXISBANK");
            arryImplementation.AddorUpdateElementToArrays(5, "BAJAJ-AUTO");
            arryImplementation.AddorUpdateElementToArrays(6, "BAJFINANCE");

            //Seacrch item in Arrya
            arryImplementation.SearchElementinArray("ADANIENT");
            arryImplementation.SearchElementinArray("wipro");

            //Print All Element In Array 
            arryImplementation.PrintAllElementInArray();

            BackgroundColor.WriteInHighlight("      ---Two-Dimensional Array---", ConsoleColor.Red);
            //Add item to 2D Array (One By one)

            BackgroundColor.WriteInHighlight("Task 1:Add element to 2D Array (One By one)", ConsoleColor.Yellow);
            arryImplementation.AddOrUpdateElementTo2Arrays(0, "ADANIENT", "3261.75");
            arryImplementation.AddOrUpdateElementTo2Arrays(1, "ADANIPORTS", "1430.70");
            arryImplementation.AddOrUpdateElementTo2Arrays(2, "ADANIPORTS", "6207.60");
            arryImplementation.AddOrUpdateElementTo2Arrays(3, "ASIANPAINT", "2921.60");
            arryImplementation.AddOrUpdateElementTo2Arrays(4, "AXISBANK", "1181.05");
            arryImplementation.AddOrUpdateElementTo2Arrays(5, "BAJAJ-AUTO", "9961.75");
            arryImplementation.AddOrUpdateElementTo2Arrays(6, "AXISBANK", "7341.55");

            BackgroundColor.WriteInHighlight("Task 2 :Update element to 2D Array (One By one)", ConsoleColor.Yellow);
            arryImplementation.AddOrUpdateElementTo2Arrays(0, "ADANIENT", "3263.75");

            //Inbuilt Feature
            arryImplementation.InbuiltMethod();
            arryImplementation.AddOrUpdateElementTo2Arrays(7, "AXISBANK", "7341.55");

        }
    }
}