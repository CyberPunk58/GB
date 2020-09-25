using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1E1
{
    class Program
    {
        /*
         * Андреев Павел
         * Написать программу «Анкета». Последовательно задаются вопросы
         (имя, фамилия, возраст, рост, вес). 
         В результате вся информация выводится в одну строчку:
                а) используя склеивание;
                б) используя форматированный вывод;
	            в) используя вывод со знаком $.
        */
        static void Main()
        {
            string name, surname;
            int age, height, weight;
            Console.WriteLine("Заполните пожалуйста анкету");
            Console.WriteLine("Введите Ваше имя:");
            name = Console.ReadLine();
            Console.WriteLine("Введите Вашу фамилию:");
            surname = Console.ReadLine();
            Console.WriteLine("Введите Ваш возраст:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Ваш рост:");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Ваш вес:");
            weight = Convert.ToInt32(Console.ReadLine());

            //Вывод склеиванием
            Console.WriteLine("Вас зовут: " + name + " " + surname + ", Вам " + age + ", Ваш рост: " + height + ", Ваш вес: " + weight + ". ");

            //Вывод с $
            Console.WriteLine($"Вас зовут: {name} {surname}, Вам {age}, Ваш рост: {height}, Ваш вес: {weight}.");

            //Форматированный вывод
            Console.WriteLine("Вас зовут: {0} {1}, Вам {2}, Ваш рост: {3}, Ваш вес: {4}.", name, surname, age, height, weight);

        }
    }
}
