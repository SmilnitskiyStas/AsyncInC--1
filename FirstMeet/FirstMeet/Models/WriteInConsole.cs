using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMeet.Models
{
    internal class WriteInConsole
    {
        public void WriteAsync(int value)
        {
            for (int i = 0; i < value; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }
}
