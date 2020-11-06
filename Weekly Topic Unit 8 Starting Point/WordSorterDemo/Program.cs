using System;
using BinaryTreeImplementation;

/*
 * ProfReynolds
 */

namespace WordSorterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<string> tree = new BinaryTree<string>();

            string consoleInput = string.Empty;

            while (!consoleInput.Equals("quit", StringComparison.CurrentCultureIgnoreCase))
            {
                // read the line from the user
                Console.Write("> ");
                consoleInput = Console.ReadLine();

                // split the line into words (on space)
                string[] words = consoleInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // add each word to the tree
                foreach (string word in words)
                {
                    tree.Add(word);
                }

                // print the number of words
                Console.WriteLine("{0} words", tree.Count);

                // and print each word using the default (in-order) enumerator
                foreach (string word in tree)
                {
                    Console.Write("{0} ", word);
                }

                Console.WriteLine();

                tree.Clear();
            }
        }
    }
}