using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HW2E5
{
    class Program
    {
        static void Main()
        {/*Андреев Павел
          * а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
          * б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
          * 
          * 
          * 
          * 
          * 
          * */
            Console.WriteLine("Введите Ваш рост в метрах: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Ваш вес: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            double imt = weight / (height * height);
            Console.WriteLine($"Ваш ИМТ = {imt:F}");
            double nweight; 
            if (imt > 25)
            {
                nweight = 25 * (height * height);
                nweight = weight - nweight;
                Console.WriteLine($"Вам необходимо похудеть на {nweight} кг");

            }
            else if (imt < 18.5)
            {
                nweight = 18.5 * (height * height);
                nweight = nweight - weight;
                Console.WriteLine($"Вам необходимо набрать {nweight} кг");
            }
            else
                Console.WriteLine("У вас нормальный вес");
        }
    }
}