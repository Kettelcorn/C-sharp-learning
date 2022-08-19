using System;
using System.Collections.Generic; //needed for different data structures (collections)


// in terminal, find file you want to start project ("cd 'folder name'" to next, cd ~ to previous)
// you can set default directory by going file-preferences-settings, then typing cwd and going under
// Terminal > Integrated:Cwd settings to change directory
// then type dotnet new console -o 'folder name' to make new project
// to run code, type dotnet run
namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            //linked list
            LinkedList<int> listy = new LinkedList<int>();
            listy.AddLast(5);
            listy.AddLast(10);
            listy.AddLast(75);
            Console.WriteLine("LinkedLists:");
            Console.WriteLine(string.Join(",", listy));
            Console.WriteLine();

            //arrays
            int[] lmao = new int[] { 1, 2, 3, 4, 5};
            int[] lmao2 = new int[3];
            lmao[2] = 5;
            string length = "" + lmao.Length; // Capital L
            Console.WriteLine("Arrays:");
            Console.WriteLine(length);
            Console.WriteLine(string.Join(",", lmao));
            Console.WriteLine();

            //hashset
            HashSet<int> hashy = new HashSet<int>();
        }
    }
}
