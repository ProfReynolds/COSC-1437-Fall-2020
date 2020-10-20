using System;

/*
 * ProfReynolds
 */

namespace NodeChains
{
    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ProfReynolds NodeChains");
            Console.WriteLine();

            /*
             * creating the first node
             * since there is no second node, the Next property is null
             */
            Node first = new Node { Value = 3 };
            //    +-----+------+
            //    |  3  | null +
            //    +-----+------+


            /*
             * creating the second node
             * now the first node 'points' to the second node
             * but there is no third node, the Next property in the second node is null
             */
            Node second = new Node { Value = 5 };
            first.Next = second;
            //    +-----+------+    +-----+------+
            //    |  3  | null +    |  5  | null +
            //    +-----+------+    +-----+------+


            /*
             * similarly, the second node points to the third, but the third points nowhere
             */
            Node third = new Node { Value = 7 };
            second.Next = third;
            //    +-----+------+    +-----+------+   +-----+------+
            //    |  3  |  *---+--->|  5  |  *---+-->|  7  | null +
            //    +-----+------+    +-----+------+   +-----+------+


            Node fourth = new Node { Value = 4444 };
            third.Next = fourth;


            Node fifth = new Node { Value = 55555 };
            fourth.Next = fifth;


            // now iterate over each node and print the value
            Console.WriteLine("\n\nPrinting Iteratively");
            PrintListIteratively(first);


            // just for practice, print recursively
            Console.WriteLine("\n\nPrinting Recursively");
            PrintListRecursively(first);

            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        private static void PrintListIteratively(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }

        private static void PrintListRecursively(Node node)
        {
            if (node == null) return;

            Console.WriteLine(node.Value);
            PrintListRecursively(node.Next);
        }

    }
}
