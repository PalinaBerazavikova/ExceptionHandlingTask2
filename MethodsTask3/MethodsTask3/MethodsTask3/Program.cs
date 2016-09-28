using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartClass sc1 = new SmartClass();
            SmartClass sc2 = new SmartClass();
            SmartClass sc3 = new SmartClass();
            sc3.Dispose();
            Console.WriteLine(SmartClass.Counter);
            Console.ReadKey();
        }
    }
}
