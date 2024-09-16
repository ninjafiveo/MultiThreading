using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create two new Thread Objects
            Thread thread1 = new Thread(Method1);
            Thread thread2 = new Thread(Method2);
            Thread thread3 = new Thread(Method3);
            Thread thread4 = new Thread(Method4);

            // start both threads
            // thread1.Start();
            // thread2.Start();

            // Start next two threads.
            //thread3.Start();
            //thread4.Start();
            // Keep the main thread alive until other threads finish.
            //thread3.Join();
            //thread4.Join();

            Console.WriteLine("Main Threads Finished.");

            // Crazy Mouse Portion
            CrazyPC.CrazyFunctionCall();
            
            Console.ReadKey();

        }
        static void Method1()
        {
            int number1 = 0;
            while (true)
            {
                Console.WriteLine(number1);
                number1 = number1 + 1;
                Thread.Sleep(500);
            }
        }
        static void Method2()
        {
            int number2 = 0;
            while (true)
            {
                Console.WriteLine(number2);
                number2 = number2 + 100;
                Thread.Sleep(3000);
            }
        }

        static void Method3()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Method 3: {i}");
                Thread.Sleep(1000); //Simutlate some work with a 1 second delay.
            }
        }
        static void Method4()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Method 4: {i}");
                Thread.Sleep(500); //Simutlate some work with a .5 second delay.
            }
        }
    
        
    }
}
