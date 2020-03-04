using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.SwapVariables(4, 9);
        }

        public void SwapVariables(int a, int b)
        {
            a -= b;
            b += a;
            a = b - a;
            Console.WriteLine("a = " + a + ", b = " + b);
        }
    }
}
