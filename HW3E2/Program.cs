using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2E3
{
    class Program
    {
        //Андреев Павел
        //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

        static void Main()
        {
            int n;
            int count = 0;
            int x;

            Numbers();

            void Numbers()
            {
                Console.WriteLine("Введите число: ");
                int.TryParse(Console.ReadLine(),out n);
                //n = Convert.ToInt32(Console.ReadLine());
                if (n == 0)
                {
                    Console.WriteLine($"Сумма нечетных чисел: {count}");
                }
                else if (n % 2 != 0 && n > 0)
                {
                    count = count + n;
                    Numbers();
                }
                else
                {
                    Numbers();
                }
            }
        }
    }
}
