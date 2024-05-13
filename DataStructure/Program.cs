using System;

using DataStructure.DataStructre; //Use namespace

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quant ALgo Lab");
            Console.WriteLine("Learn Data Structure using C# ");

            Console.WriteLine("Prog 1 : Struct - User Defined Data Types ");
            Struct_Implement struct_Implement = new Struct_Implement();
            struct_Implement.Insert_toStocklist();
            struct_Implement.PrintAll();    

           Console.ReadKey();   



        }
    }
}