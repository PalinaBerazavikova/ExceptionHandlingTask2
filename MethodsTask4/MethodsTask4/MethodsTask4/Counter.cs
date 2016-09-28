using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsTask4
{
    class Counter
    {
        public double Square { get; set; }

        public Counter(double s)
        {
            this.Square = s;
        }

        public int CountRect(double x, double y)
        {
            return (int)(this.Square/(x*y)); 
        }
    }
}
