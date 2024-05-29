
using DataStructure.Struct; //Use namespace

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
            struct_Implement.addStock_toMylist();
            struct_Implement.DisplayAll();

            //Copy Item from One Struct to another
            // 3 as argument suiggest, we are looking for struct stock object at location index 3
            struct_Implement.copyStructure(3);

           Console.ReadKey();   



        }
    }
}