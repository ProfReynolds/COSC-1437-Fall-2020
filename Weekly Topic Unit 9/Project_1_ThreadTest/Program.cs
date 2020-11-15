using System;
using System.Collections.Generic;
using System.Threading;

/*
 * Prof Reynolds *
 */

namespace Project_1_ThreadTest
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
            Console.WriteLine("Weekly Topic Unit 9");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1) Demo the ThreadTest");
                Console.WriteLine("2) Demo the ThreadTest2");
                Console.WriteLine("3) Demo the ThreadTest3");
                Console.WriteLine("4) Demo the ThreadTest4");
                Console.WriteLine("5) Demo the ThreadTest5");
                Console.WriteLine("6) Demo the ThreadTest6");
                Console.WriteLine("7) Demo the ThreadTest7");
                Console.WriteLine("X) exit");
                Console.Write("Select demonstration:");

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

                    case '1': ThreadTest(); break;
                    case '2': ThreadTest2(); break;
                    case '3': ThreadTest3(); break;
                    case '4': ThreadTest4(); break;
                    case '5': ThreadTest5(); break;
                    case '6': ThreadTest6(); break;
                    case '7': ThreadTest7(); break;

                    default:
                        break;
                }
                Console.WriteLine();
            }
        }

        private static int ThreadTest()
        {
            void WriteY()
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write("y");
                }
            }

            void WriteZ()
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write("z");
                }
            }

            void WriteW()
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write("w");
                }
            }

            Thread ty = new Thread(WriteY);
            ty.Start();

            #region herein is similar code to implement a thread test for tz / WriteZ() and tw / WriteW();
            Thread tz = new Thread(WriteZ);
            tz.Start();

            Thread tw = new Thread(WriteW);
            tw.Start();
            #endregion

            for (int i = 0; i < 1000; i++)
            {
                Console.Write("X");
            }

            return 0;
        }
        private static int ThreadTest2()
        {
            void WriteAString(string StringToWrite)
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write(StringToWrite);
                }
            }

            Thread ty = new Thread(() => WriteAString("y"));
            ty.Start();

            #region herein is similar code to implement a thread test for tz and tw
            Thread tz = new Thread(() => WriteAString("z"));
            tz.Start();

            Thread tw = new Thread(() => WriteAString("w"));
            tw.Start();
            #endregion

            for (int i = 0; i < 5; i++)
            {
                WriteAString("X");
            }

            return 0;
        }

        private static int ThreadTest3()
        {
            void WriteAString(string StringToWrite)
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write(StringToWrite);
                }
            }

            Thread ty = new Thread(() => WriteAString("y"));
            ty.Start();

            #region herein is similar code to implement a thread test for tz and tw
            Thread tz = new Thread(() => WriteAString("z"));
            tz.Start();

            Thread tw = new Thread(() => WriteAString("w"));
            tw.Start();
            #endregion

            for (int i = 0; i < 5; i++)
            {
                WriteAString("X");
            }

            System.Threading.Thread.Sleep(5000);

            return 0;
        }

        private static int ThreadTest4()
        {
            void WriteAString(object StringToWrite)
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write(StringToWrite);
                }
            }

            Thread ty = new Thread(() => WriteAString("y"));
            ty.Start();

            Thread tz = new Thread(WriteAString);
            tz.Start("z");

            Thread tw = new Thread(WriteAString);
            tw.Start("w");

            for (int i = 0; i < 5; i++)
            {
                WriteAString("X");
            }

            while (ty.IsAlive || tz.IsAlive || tw.IsAlive)
            {
                System.Threading.Thread.Sleep(10);
            }

            return 0;
        }

        private static int ThreadTest5()
        {
            void WriteAString(object StringToWrite)
            {
                for (int i = 0; i < 25; i++)
                {
                    Console.Write(StringToWrite);
                }
            }

            Thread[] aBunchOfThreads = new Thread[10];

            for (int threadNumber = 0; threadNumber < 10; threadNumber++)
            {
                //var thisThread = aBunchOfThreads[threadNumber];
                //var tn = threadNumber.ToString();
                //thisThread = new Thread(() => WriteAString(tn.ToString()));
                //thisThread.Start();

                aBunchOfThreads[threadNumber] = new Thread(() => WriteAString(threadNumber.ToString()));

                aBunchOfThreads[threadNumber].Start();
            }

            for (int i = 0; i < 5; i++)
            {
                WriteAString("X");
            }

            while (true)
            {
                var aThreadIsStillRunning = false;

                for (var threadNumber = 0; threadNumber < 10; threadNumber++)
                {
                    aThreadIsStillRunning = aThreadIsStillRunning || aBunchOfThreads[threadNumber].IsAlive;
                }

                if (!aThreadIsStillRunning) break;

                System.Threading.Thread.Sleep(10);
            }


            return 0;
        }

        private static int ThreadTest6()
        {
            void WriteAString(object StringToWrite)
            {
                for (int i = 0; i < 25; i++)
                {
                    Console.Write(StringToWrite);
                }
            }

            Thread[] aBunchOfThreads = new Thread[10];

            for (int threadNumber = 0; threadNumber < 10; threadNumber++)
            {
                aBunchOfThreads[threadNumber] = new Thread(() => WriteAString(threadNumber.ToString()));
                aBunchOfThreads[threadNumber].Start();
            }

            for (int i = 0; i < 5; i++)
            {
                WriteAString("X");
            }

            for (var threadNumber = 0; threadNumber < 10; threadNumber++)
            {
                aBunchOfThreads[threadNumber].Join();
            }

            return 0;
        }

        static bool _done; // Static fields are shared between all threads

        static int ThreadTest7()
        {
            _done = false;
            new Thread(Go).Start(); // starts a process and executes Go()
            Go(); // and implements Go() again
            return 0;
        }

        static void Go()
        {
            if (!_done)
            {
                Thread.Sleep(10);
                // will we reach this point once or twice???
                _done = true;
                Console.WriteLine("Method 'Go' has been reached, _done is now true");
            }
        }

    }
}