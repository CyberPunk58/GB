using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1E2
{
    class Program
    {

        /*Андреев Павел
         * 
         * Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) 
         * по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
         */
        static void Main()
        {
            float height, weight, i;
            
            Console.WriteLine("Введите Ваш рост (в метрах):");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите Ваш вес:");
            weight = float.Parse(Console.ReadLine());

            i = weight / (height * height); //Вычисляем ИМТ

            Console.WriteLine($"Ваш ИМТ = {i:F}");
        }
    }
}
