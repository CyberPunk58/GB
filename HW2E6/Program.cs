using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2E5
{
    class Program
    {

        /*Андреев Павел
         * *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр.
         * Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
         * 
         * 
         * 
         * 
         * */
        static void Main()
        {
            DateTime nowTime = DateTime.Now;
            Console.WriteLine(nowTime);
            int a, sum = 0, count = 0;
            for (int i = 1; i < 1_000_000_001; i++)
            {
                a = i;
                sum = 0;
                while (a > 0)
                {
                    sum = sum + a % 10;
                    //a = a / 10;
                    a /= 10;
                }
                if (i % sum == 0)
                {
                    count++;
                }
            }
            DateTime nowTime1 = DateTime.Now;
            Console.WriteLine(nowTime1);
            TimeSpan date = nowTime1 - nowTime;
            int sec = date.Minutes * 60 + date.Seconds;        //Считаем секунды
            Console.WriteLine($"было затрачено {sec} секунд");
            Console.WriteLine($"Хороших чисел - {count}");
        }
    }
}
