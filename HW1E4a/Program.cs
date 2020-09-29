using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW1E6;

namespace HW1E5
{
    class Program
    {
        /*Андреев Павел
         * а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
         * б) *Сделать задание, только вывод организовать в центре экрана.
         * в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
         * 
         */
        static void Main()
        {
            //Простой вывод
            Console.WriteLine("Андреев Павел, город Пенза");
            
            //вывод в центре консоли

            string text = "Андреев Павел, город Пенза (по центру)";
            int centerX = (Console.WindowWidth / 2) - (text.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX, centerY);
            Console.WriteLine(text);

            //Вывод в заданных координатах

            Print("Андреев Павел, город Пенза", 10, 20);

            void Print(string t1, int x, int y) //Метод вывода строки в заданных координатах
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(t1);
            }
            string t2 = "Работа метода из другого проекта";
            HW1E6.Program.MyPrint(t2); //метод по ссылке из HW1E6

            HW1E6.Program.Pause(); //метод по ссылке из HW1E6









        }


    
    }
}
