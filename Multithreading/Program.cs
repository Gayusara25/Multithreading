using System;
using System.Threading;
namespace Multithreading
{
    class Program
    {
        public static void Main()
        {
            Thread T1 = new Thread(Write);
            Thread T2 = new Thread(Read);
            T1.Start();
            T2.Start();
            Console.ReadKey();
        }

        static void Write()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Writing is in process");

                if (i == 5)
                {
                    Console.WriteLine("Writing is on hold");
                    Thread.Sleep(5000);
                    Console.WriteLine("Writing is wokeup");
                }
            }
            
        }
        static void Read()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Reading is in process");
            }

        }
    }
}