using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextLeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.NextLeapYear(2097));
        }

        public int NextLeapYear(int year) {
            int i;
            for (i = year; i < year + 8; i++)
            {
                if ((i % 400 == 0) || ((i % 4 == 0) && (i % 100 != 0)))

                {
                    return i;
                }
            }
            return -1;
        }
    }
}
