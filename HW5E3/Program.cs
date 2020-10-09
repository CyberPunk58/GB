using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5E3
{


    /*Андреев Павел
     
     * *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
        Например:
        badc являются перестановкой abcd.

     * 
     * 
     */
    class Program
    {
        static void Main()
        {
            int[] arr1 = new int[20000];
            int[] arr2 = new int[20000];

            Console.WriteLine("Введите 1 строку:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите 2 строку:");
            string str2 = Console.ReadLine();

            for (int i = 0; i < str1.Length; i++)
            {
                int c = (int)str1[i];
                arr1[c]++;

            }
            for (int i = 0; i < str2.Length; i++)
            {
                int c = (int)str2[i];
                arr2[c]++;

            }
           if (arr1.SequenceEqual(arr2))
            {
                Console.WriteLine("Строки равны");

            }
            else
            {
                Console.WriteLine("Строки не равны");
            }
        }
    }
}
