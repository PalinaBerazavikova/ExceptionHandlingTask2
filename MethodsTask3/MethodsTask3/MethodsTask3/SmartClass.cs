using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsTask3
{
    public class SmartClass:IDisposable
    {
        private static int counter = 0;
        public static int Counter { get { return counter; } set { counter = value; } }

         public void Dispose()
        {
            Counter--;
        }

        public SmartClass()
        {
            Counter++;
        }

    }
}
