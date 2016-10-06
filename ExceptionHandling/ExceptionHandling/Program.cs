using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            FileHandler fileHandler = new FileHandler();
            fileHandler.getPath();
            Console.ReadKey();
        }
    }
}
