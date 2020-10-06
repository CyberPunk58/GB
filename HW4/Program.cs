using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{

    /*Андреев Павел
     * Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
     * 
     * 
     * 
     * 
     * 
     */
    class Program
    {
        static void Main()
        {
            int[] arr = new int[20];

            Random r = new Random();
            int count = 0;

            for (int i = 0; i<20; i++)
            {
                arr[i] = r.Next(-10000, 10000);
                Console.WriteLine($"{arr[i]}    {arr[i]%3}");
            }

            for (int i = 0; i<19; i++)
            {
                if (arr[i]%3 == 0 && arr[i+1]%3 == 0)
                {
                    count++; 
                }
                           
            }
            Console.WriteLine(count);
        }

    }
}
