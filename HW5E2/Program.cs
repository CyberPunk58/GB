using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace HW5E2
{
    class Message
    {
        /*Андреев Павел
         * Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
            а) Вывести только те слова сообщения,  которые содержат не более n букв.
            б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            в) Найти самое длинное слово сообщения.
            г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.

         * 
         * 
         * 
         */





        public static StringBuilder maxWords(string _message)  //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.

        {
            string[] arr;
            string max = "";
            int len = 0;
            StringBuilder str = new StringBuilder();
            char[] splitchar = { ' ', ',', '.' };
            arr = _message.Split(splitchar);

            foreach (string el in arr)
            {
                if (el.Length >= len)
                {
                    len = el.Length;
                }
            }

            foreach (string el in arr)
            {
                if (el.Length == len)
                {
                    str.Append(" "+el);
                }


            }

            return str;
        }
        public static string maxWord(string _message)  //в) Найти самое длинное слово сообщения.

        {
            string[] arr;
            string max = "";
            int len = 0;
            char[] splitchar = { ' ', ',', '.' };
            arr = _message.Split(splitchar);

            foreach (string el in arr)
            {
                if (el.Length >= len)
                {
                    max = el;
                    len = el.Length;
                }
            }
            

            return max;
        }
        
        public static void delWord(string _message, string s) //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        {
            string q = @"\b\w*" + s + @"\b";
            //Regex myReg = new Regex(@"\\w" + s + "\b");
            Regex myReg = new Regex(q);
            //string _myReg = @"\b";
            Console.WriteLine(myReg.Replace(_message, string.Empty));



        }
        public static string[] nLetters(string _message, int n) //а) Вывести только те слова сообщения,  которые содержат не более n букв.

        {
            string[] arr;
            char[] splitchar = {' ',',','.' };
            arr = _message.Split(splitchar);
             
            foreach (string el in arr)
            {
                if (el.Length <= n && el.Length > 0)
                {
                    Console.WriteLine(el);
                }
            }

            return (arr);
        }


    }
    
    class Program
    {
        static void Main()
        {
            #region Задача а
            Console.WriteLine("Введите сообщение: ");
            string message = Console.ReadLine();

            string[] arr2;
            arr2 = Message.nLetters(message, 4);

            foreach (string el in arr2)
            {
                Console.Write(el);
            }
            #endregion
            #region Задача б
            //Message.delWord("маму мыла раму ,kg,kg,kg", "а");
            #endregion

            #region Задача в

            //Console.WriteLine("Введите сообщение: ");
            //string message2 = Console.ReadLine();
            //Console.WriteLine(Message.maxWord(message));


            #endregion

            #region Задача г
            //Console.WriteLine("Введите сообщение: ");
            //string message3 = Console.ReadLine();
            //Console.WriteLine(Message.maxWords(message));


            #endregion
        }
    }
}
