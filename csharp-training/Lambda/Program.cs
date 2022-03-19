using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fruitList = new List<string>() { "Banana", "Apple", "Cherry", "Apricot", "Peach", "Pear" };
            var fruitsWithA = fruitList.Where(fruit => {
                Console.WriteLine("Filtering...");
                return fruit.StartsWith('A');
            });

            Console.WriteLine("\nList of fruits\n");
            fruitList.ForEach(fruit => Console.WriteLine(fruit));

            Console.WriteLine("\nCalling fruitsWithA.ToList() to create fruits2\n");
            var fruits2 = fruitsWithA.ToList();

            Console.WriteLine("\nLooping through fruits2\n");
            foreach(var fruit in fruits2)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("\nLooping through fruitsWithA.ToList()\n");
            foreach(var fruit in fruitsWithA.ToList())
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("\nLooping through fruitsWithA\n");
            foreach (var fruit in fruitsWithA)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("\nLooping through fruitsWithA.OrderByDescending(x => x).ToList()\n");
            foreach (var fruit in fruitsWithA.OrderByDescending(x => x).ToList())
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("\nLooping through fruitsWithA.OrderByDescending(x => x)\n");
            foreach (var fruit in fruitsWithA.OrderByDescending(x => x))
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
