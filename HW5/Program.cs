using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{


    /*Андреев Павел
     * Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
        а) без использования регулярных выражений;

     * 
     * 
     * 
     */
    class Program
    {
        static void Main()
        {
            string login;
            int ca = (int)('a');
            int cba = (int)('A');
            char s;

            Console.WriteLine("Введите логин: ");
            login = Console.ReadLine();

            if (login.Length > 10 | login.Length < 2)
            {
                Console.WriteLine("Логин должен содержать от 2 до 10 символов.");
                return;
            }
            
            if (Char.IsDigit(login[0]))
                {
                    Console.WriteLine("Первый символ не может быть цифрой.");
                return;
            }
            for (int i = 0; i < login.Length; i++)
            {
                s = login[i];
                if (!((s >= ca && s<= ca+25) | (s >= cba && s <= cba + 25) | (Char.IsDigit(s))))
                {
                    Console.WriteLine(" Не верный логин");
                    return;  
                }
                

            }
            Console.WriteLine("Логин принят.");

        }
    }
}
