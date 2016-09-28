using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter count = new Counter(345.34);
            Console.WriteLine(count.CountRect(12.1, 12.5));
            Console.ReadKey();
        }
    }
}
