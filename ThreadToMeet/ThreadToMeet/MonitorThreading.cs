using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadToMeet
{
    internal class MonitorThreading
    {
        /*
         * Monitor для синхронізації потоків.
         */

        private object _locker = new object();

        private int _x = 0;
        public MonitorThreading()
        {
            // Запуск потоків
            for (int i = 1; i < 6; i++)
            {
                Thread thread = new Thread(Print);
                thread.Name = $"Thread: {i}";
                thread.Start();
            }
        }

        private void Print()
        {
            bool acquiredLock = false;

            try
            {
                // _locker - блокуючий об'єкт.
                // acquiredLock - вказує на результат блокування (якщо true, бо блокування виконано).
                Monitor.Enter(_locker, ref acquiredLock);

                _x = 1;

                for (int i = 1; i < 6; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {_x}");

                    _x++;

                    Thread.Sleep(300);
                }
            }
            finally
            {
                if (acquiredLock)
                {
                    // Звільняємо об'єкт _locker.
                    Monitor.Exit(_locker);
                }
            }
        }
    }
}
