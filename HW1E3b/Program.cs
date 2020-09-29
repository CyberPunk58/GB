using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1E3b
{

    /*Андреев Павел
     * б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
     * 
     */
    class Program
    {
        static void Main()

        {   
            double x1, x2, y1, y2;
            Console.Write("Введите кординату х1. для первой точки: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите кординату y1. для первой точки: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите кординату х2. для первой точки: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите кординату y2. для первой точки: ");
            y2 = Convert.ToDouble(Console.ReadLine());

                     
            Console.WriteLine($"{Distance(x1, y1, x2, y2):F2}");

            double Distance(double x11, double y11, double x22, double y22)   //Метод подсчета расстояния между двумя точками
            {
                double r;                               
                r = Math.Sqrt(Math.Pow(x22 - x11, 2) + Math.Pow(y22 - y11, 2));           
                return r;

            }
        }
    }
}
