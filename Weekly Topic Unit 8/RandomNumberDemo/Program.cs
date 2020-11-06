using System;
using System.Text.RegularExpressions;
using BinaryTreeImplementation;

/*
 * ProfReynolds
 */

namespace RandomNumberDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ProfReynolds - Assignment 8");

            var tree = new BinaryTree<int>();

            var rnd = new Random();

            Console.WriteLine("\nAs loaded ...");
            for (var loopvar = 0; loopvar < 10; loopvar++)
            {
                var nextValue = rnd.Next(0, 100);
                tree.Add(nextValue);
                Console.Write($"{nextValue} ");
            }
            Console.WriteLine();

            Console.WriteLine($"\n{tree.Count} words");

            Console.WriteLine("\nAs retrieved ...");
            foreach (var word in tree)
            {
                Console.Write($"{word} ");
            }

            Console.WriteLine();
        }
    }
}
