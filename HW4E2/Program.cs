using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW4E2
{
    /*Андреев Павел
     * Реализуйте задачу 1 в виде статического класса StaticClass;
     *   а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
     *  б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
     * в)**Добавьте обработку ситуации отсутствия файла на диске.
     * 
     * 
     * 
     * 
     * 
     * */
    class Program
    {

        
        static class StaticClass        
        {
            static int count = 0;
            
             static int[] ArrayRead()
            {
                int[] arr = new int[10];
                StreamReader sr = new StreamReader(@"C:\Users\PROG2\source\repos\HW4\array.txt");
                
                while (!sr.EndOfStream)
                {
                      for (int i = 0; i<10; i++)
                    {
                        arr[i] = Convert.ToInt32(sr.ReadLine());
                    }
                }          
                
               
                return arr;
            }
            
            static void ArrayCount(int[] a)     //метод для проверки деления соседних чисел на 3
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[i] % 3 == 0 && a[i + 1] % 3 == 0)
                    {
                        count++;
                       

                    }
                }
                Console.WriteLine(count);

            }


            static void Main()
            {
               
                int[] arr =  StaticClass.ArrayRead();
                StaticClass.ArrayCount(arr);
           
            }
        }
    }
}
