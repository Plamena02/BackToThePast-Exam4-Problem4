using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Past
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = double.Parse(Console.ReadLine());
            var g = int.Parse(Console.ReadLine());
            var v = 18;
            for (int i = 1800; i <= g; i++)
            {
                if (i % 2 == 0)
                {
                    m-= 12000;
                }
                else
                {
                    m-= 12000 + (50 * v);
                }
                v += 1;
            }
            if (0<= m)
            { Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.",m ); }
            else
            {
                Console.WriteLine("He will need {0:F2} dollars to survive.", Math.Abs(m));
            }
        }
    }
}
