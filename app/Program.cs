using System;
using System.Collections.Generic;


// in terminal, find file you want to start project ("cd 'folder name'" to next, cd ~ to previous)
// then type dotnet new console -o 'folder name' to make new project
// to run code, type dotnet run
namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> listy = new LinkedList<int>();
            listy.AddLast(5);
            listy.AddLast(10);
            listy.AddLast(75);
            Console.WriteLine(string.Join(",", listy));
            Console.WriteLine("Hellow World");
        }
    }
}
