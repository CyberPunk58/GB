using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HW5E1_2
{
    /*Андреев Павел
     * Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
  
         б) **с использованием регулярных выражений.

     * 
     * 
     * 
     * 
     * 
     */

    class Program
    {
        static void Main(string[] args)
        {
            string login;

            Regex myReg = new Regex("^[A-Za-z][A-Za-z0-9]{1,9}$");
            
            Console.WriteLine("Введите логин: ");
            login = Console.ReadLine();
                        
            if (myReg.IsMatch(login) == true)
            {
                Console.WriteLine("Логин принят.");

            }
            else

                Console.WriteLine("Логин не принят"); 
        }
    }
}
