using System;
using System.Threading;

/*
 * Prof Reynolds *
 */

namespace Project_2_ThreadSafe
{
    class Program
    {
        /*
         * Alternate menu approach
        static Dictionary<char, Action> ConsoleMenuDictionary = new Dictionary<char, Action>
        {
            {'1', () => AwaitDemo1()},
            {'2', () => AwaitDemo2()},
        };
        */

        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Mark Reynolds");
            Console.WriteLine("Weekly Topic Unit 10, Project 2");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1) Demo the ThreadSafeTest");
                Console.WriteLine("X) exit");
                Console.Write("Select demonstration: ");

                var keyPressed = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.WriteLine();

                /*
                 * Alternate menu approach
                if (keyPressed == 'x' || keyPressed == 'X') return;
        
                try
                {
                    ConsoleMenuDictionary[keyPressed].Invoke();
                }
                catch { }
                 */

                switch (keyPressed)
                {
                    case 'x':
                    case 'X':
                        return;

                    case '1': ThreadSafeTest(); break;

                    default:
                        break;
                }
                Console.WriteLine();
            }
        }

        static bool _done;

        static readonly object Locker = new object();

        static int ThreadSafeTest()
        {
            /*
             * why is this important?
             * try running this step multiple times without it
             *
             * student: explain why it is important.
             */
            _done = false;

            new Thread(Go).Start();
            Go();

            return 0;
        }

        static void Go()
        {
            lock (Locker)
            {
                if (!_done)
                {
                    Thread.Sleep(10);
                    // will we reach this point once or twice???
                    _done = true;
                    Console.WriteLine("Done");
                }
            }

        }
    }
}