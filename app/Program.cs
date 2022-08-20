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
            // doc: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=net-6.0
            LinkedList<int> listy = new LinkedList<int>();
            listy.AddLast(5); //adds value to end of linked list
            listy.AddLast(10);
            listy.AddLast(75);
            LinkedListNode<int> pointer = listy.First; // doc: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlistnode-1?view=net-6.0
            Console.WriteLine("The first element in this linked list is: " + pointer.Value);
            Console.WriteLine("The next element is: " + pointer.Next.Value);
            Console.WriteLine("LinkedLists:");
            Console.WriteLine(string.Join(",", listy)); //prints linked list in string form
            IEnumerator<int> en = listy.GetEnumerator(); //sets up enumerator to iterate through linked list
            en.Reset(); // sets position to begining of linked list
            while (en.MoveNext()) //checks if there is another node in linked list
            {
                Console.WriteLine(en.Current);   
            }
            Console.WriteLine();



            //arrays
            int[] lmao = new int[] { 1, 2, 3, 4, 5};
            int[] lmao2 = new int[3];
            lmao[2] = 5;
            Console.WriteLine("Arrays:");
            Console.WriteLine(lmao.Length); //capital L
            Console.WriteLine(string.Join(",", lmao));
            Console.WriteLine();

            //hashset
            HashSet<int> hashy = new HashSet<int>();
        }
    }
}
