using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b = 11, c;

            Console.WriteLine("Digite um numero");
            a = Convert.ToDouble(Console.ReadLine());

            while (b >= 1)
            {
                b = b - 1;
                c = a * b;
                Console.WriteLine(a + "*" + b + "=" + c);
            }

            Console.ReadKey();
        }
    }
}
