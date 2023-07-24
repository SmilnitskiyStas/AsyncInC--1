using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadToMeet
{
    internal class Learn_ParameterizedThreadStart
    {
        /*
         * Передача параметрів потоку.
         */
        public Learn_ParameterizedThreadStart()
        {
            Person person = new Person("Stas", "Smile", "+380668809692");

            Thread thread1 = new Thread(new ParameterizedThreadStart(Print));
            Thread thread2 = new Thread(message => Console.WriteLine(message));

            // Потоки із параметрами.
            Thread thread3 = new Thread(new ParameterizedThreadStart(PrintClassInfo));

            thread1.Start("Hello, my name is Stas!");
            thread2.Start("New message!");
            thread3.Start(person);
        }

        private void Print(object? message)
        {
            Console.WriteLine(message);
            Thread.Sleep(300);
        }

        private void PrintClassInfo(object? message)
        {
            if (message is Person person)
            {
                Console.WriteLine($"Name: {person.Name}, LastName: {person.LastName}, PhoneNumber: {person.PhoneNumber}");
                Thread.Sleep(400);
            }
        }
    }
}
