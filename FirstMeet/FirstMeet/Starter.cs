using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstMeet.Models;

namespace FirstMeet
{
    internal class Starter
    {
        public void Run()
        {
            WriteInConsole writeInConsole = new WriteInConsole();

            Task task = new Task(() => Console.WriteLine("Start!"));

            task = Task.Run(() => writeInConsole.WriteAsync(10));
            task.Wait();
        }
    }
}
