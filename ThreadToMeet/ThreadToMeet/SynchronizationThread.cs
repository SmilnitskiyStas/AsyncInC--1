using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadToMeet
{
    internal class SynchronizationThread
    {
        /*
         * Синхронізація потоків
         * Через Locker
         */

        // об'єкт-заглушка.
        private object _locker = new object();

        private int _x = 0;

        public SynchronizationThread()
        {
            // Запускаємо потоки.
            for (int i = 1; i < 6; i++)
            {
                Thread thread = new Thread(Print);
                thread.Name = $"Thred - {i}";
                thread.Start();
            }
        }

        public void Print()
        {
            lock (_locker)
            {
                _x = 1;

                for (int i = 1; i < 6; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {_x}");

                    _x++;

                    Thread.Sleep(300);
                }
            }
        }
    }
}
