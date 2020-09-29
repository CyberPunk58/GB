using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2E4
{
    class Program
    {

        /*Андреев Павел
         * Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
         * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
         * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
         * программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками. 
         * 
         * 
         * */
        static void Main()
        {
            int count = 0;
            bool auten() //Метод проверки логина и пароля
            {
                string l, p, login = "root", pass = "GeekBrains";
                Console.Write("Введите логин: ");
                l = Console.ReadLine();
                Console.Write("Введите пароль: ");
                p = Console.ReadLine();
                if (l != login | p != pass) return false;
                else return true;
            }
            Console.WriteLine("Для входа в программу необходимо пройти авторизацию.");
            do
            {
                if (auten() == true)
                {
                    Console.WriteLine("Успешный вход.");
                    count = 4;               
                }
                else
                {
                    count++;
                    Console.WriteLine($"Ошибка, у Вас осталось {3 - count} попыток.");
                }
            }
            while (count < 3);

        }
    }
}
