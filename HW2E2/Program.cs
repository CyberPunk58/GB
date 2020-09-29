using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2E2
{
    class Program
    {
        //Андреев Павел
        //Написать метод подсчета количества цифр числа.
        static void Main()

        {
            string n;
            int l;
            Console.WriteLine("Введите любое число: ");
            n = Console.ReadLine(); 
            l = n.Length;
            Console.WriteLine($"Количество цифр в Вашем числе: {l}");



        }

    }
}
