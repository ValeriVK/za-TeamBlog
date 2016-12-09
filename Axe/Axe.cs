using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Axe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //3*n "-"
            Console.Write(new string('-',3*n));
            Console.Write("**");
            Console.WriteLine(new string('-',2*n-2));
            for (int i = 1; i < n; i++)
            {
                Console.Write(new string('-', 3 * n));
                Console.Write("*");
                Console.Write(new string('-', i));
                Console.Write("*");
                Console.WriteLine(new string('-', 2*n-2-i));
            }
            for (int j = 1; j <= n/2; j++)
            {
                Console.Write(new string('*', 3 * n + 1));
                Console.Write(new string('-', n - 1));
                Console.Write("*");
                Console.WriteLine(new string('-', n - 1));
            }
            for (int k = 0; k <= n/2-1; k++)
            {
                Console.Write(new string('-', 3 * n -k ));
                Console.Write("*");
                if (k != n / 2 - 1)
                Console.Write(new string('-', n - 1 + 2 * k));
                else
                Console.Write(new string('*', n - 1 + 2 * k));
                Console.Write("*");
                Console.WriteLine(new string('-', n - 1 - k));
            }

        }


    }
}
