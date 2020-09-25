using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1E6
{
    public class Program
    {
        /**Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
         *  
         */


        //Создал метод MyPrint, подключил ссылку в HW1E5
        public static void MyPrint(string t1) //Метод для печати текста
        {
            Console.WriteLine(t1);
            //  return;
        }


        public static void Pause() //Метод для ожидания нажатия клавиши, после выполнения программы
        {

            Console.ReadKey();  
        }
        public static void Main()
        {
       
        }

    }
}
