using System;
using System.Threading;

namespace Thread1
{
    class Program
    {

        private static bool isCompleted;
        static object lockComplete = new object();

        static void Main(string[] args)
        {

            Thread thread = new Thread(HelloWorld);
            //Worker Thread
            thread.Start();
            //Main thread
            HelloWorld();

        }
        static void HelloWorld()
        {
            lock (lockComplete)
            {
                if (!isCompleted)
                    isCompleted = true;
                Console.WriteLine("Hello World! should printed");
            }
        }
    }
}
