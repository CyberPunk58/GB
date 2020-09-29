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
         *   a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
         * 
        */
        static void Main()
        {
            //a

            Console.WriteLine("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());

            void Numbers(int c, int d)
            {
                if (c <= d)
                {
                    Console.WriteLine(c);
                    Numbers(c + 1, d);


                }
            }
            Numbers(a, b);

             }

    }
}
