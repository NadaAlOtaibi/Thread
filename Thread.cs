using System;
using System.Threading;

namespace Thread1
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread thread1 = new Thread(print1);
            Thread thread2 = new Thread(print2);
            Thread thread3 = new Thread(print3);

            thread1.Start();
            thread2.Start();
            thread3.Start();

            // Console.WriteLine("Hello World!");
        }
        static void print1()
        {
            for (int i = 0; ; i++)
            {
                Console.WriteLine("print1");
            }
        }
        static void print2()
        {
            for (int i = 0; ; i++)
            {
                Console.WriteLine("print2");
            }
        }
        static void print3()
        {
            for (int i = 0; ; i++)
            {
                Console.WriteLine("print3");
            }
        }
    }
}
