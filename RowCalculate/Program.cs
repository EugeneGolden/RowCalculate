using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class CalculateRow
    {
        //Дано натуральное число n. Вычислить 1^1 - 2^2 + 3^3 -... ±n^n.

        public int Row(int n)
        {
            int summa = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    summa = summa + (int)Math.Pow(i, i);
                }
                else
                {
                    summa = summa - (int)Math.Pow(i, i);
                }

            }
            return summa;
        }

        static void Main(string[] args)
        {
            int n;
            int result = 0;

            Console.Write("Enter an integer number: ");

            n = int.Parse(Console.ReadLine());
            CalculateRow cr = new CalculateRow();
            result = cr.Row(n);
            Console.WriteLine("Result of calcualtion is " + result);
            Console.ReadKey();

        }

    }
}