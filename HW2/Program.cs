using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2E1
{
    class Program
    {
        //Андреев Павел
        //Написать метод, возвращающий минимальное из трёх чисел.

        static void Main()
        {
            int n1, n2, n3, min;
            Console.WriteLine("Введите первое число: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 < n2 && n1 < n3) min = n1;
            else if (n2 < n3) min = n2;
            else min = n3;
            Console.WriteLine($"Минимальное число: {min}");
        }
    }
}
