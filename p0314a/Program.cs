using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p0314a
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a}+{b}=" + (a + b).ToString());
            Console.ReadLine();
        }
    }
}
