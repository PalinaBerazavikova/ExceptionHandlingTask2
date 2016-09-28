using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Creater creater = new Creater();
            creater.Start();
            Console.ReadKey();
        }
    }
}
