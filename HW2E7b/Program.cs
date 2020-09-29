using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2E7
{
    class Program
    {

        /*
         *   
         *   б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
        */
        static void Main()
        {
            Console.WriteLine("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int Numbers(int c, int d)
            {
                if (c <= d)
                {
                    return c + Numbers(c + 1, d);
                }
                else

                    return 0;

            }
            sum = Numbers(a, b);
            Console.WriteLine(sum);
        }

    }
}
