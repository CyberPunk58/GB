using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1E3
{
    /*Андреев Павел
     * а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
     * по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, 
     * используя спецификатор формата .2f (с двумя знаками после запятой);
     * 
     */
    class Program
    {
        static void Main()
        {

            
            double x1, x2, y1, y2, r;
            Console.Write("Введите кординату х1. для первой точки: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите кординату y1. для первой точки: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите кординату х2. для первой точки: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите кординату y2. для первой точки: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"{r:F2}");

        }
    }
}
