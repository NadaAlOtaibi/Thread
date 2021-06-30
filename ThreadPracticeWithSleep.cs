using System;
using System.Threading;

namespace Thread1
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread thread = new Thread(HelloWorld);

            thread.Start();
            thread.Join();

            Console.WriteLine("Hello World! printed");
        }
        static void HelloWorld()
        {
            {
                Console.WriteLine("Hello World!");
                Thread.Sleep(6000);
            }
        }
    }
}
