using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadToMeet
{
    internal class Learn_ThreadStart
    {
        public Learn_ThreadStart()
        {
            Thread thread1 = new Thread(Print);
            Thread thread2 = new Thread(new ThreadStart(PrintAsync));
            Thread thread3 = new Thread(new ThreadStart(PrintCicle));

            thread1.Start();
            thread2.Start();
            thread3.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Основний потік: {i}");
                Thread.Sleep(500);
            }
        }

        void PrintAsync() => Console.WriteLine("Hello Async!");

        void Print()
        {
            Console.WriteLine("Hello");
        }

        void PrintCicle()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Другорядний потік: {i}");
                Thread.Sleep(550);
            }
        }
    }
}
