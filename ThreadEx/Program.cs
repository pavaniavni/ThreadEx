using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threading
{
    internal class ExampleofThread
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(MethodThread);
            Console.WriteLine(thread.ThreadState);
            thread.Start();
            Console.WriteLine(thread.ThreadState);
            thread.Join();
            Console.WriteLine(thread.ThreadState);
            Console.WriteLine("Work completed");
        }

        static void MethodThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Work in progress");
            }
        }
    }
}
