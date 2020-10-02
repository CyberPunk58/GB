using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3E3
{
    /*Андреев Павел
    * Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
    * Добавить свойства типа int для доступа к числителю и знаменателю;
    * Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
    ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
    *** Добавить упрощение дробей.
    * 
    * 
    * 
    * 
    * 
    */


    //вводим класс для дробей
    class Fraction
    {
        public int num;  //объявляем переменную для числителя, для просто ты возьмем целые числа.
        public int den, resnum, resden; //знаменатель
        public double doubres;   //для вывода десятичной дроби

        public Fraction()
        {

            num = 0;
            den = 0;
            resden = 0;
            resnum = 0;
        }

        public Fraction(int _num, int _den)
        {

            num = _num;
            den = _den;
            //Console.WriteLine("Введите числитель: ");
            //Int32.TryParse(Console.ReadLine(), out _num);

            //Console.WriteLine("Введите знаменатель: ");
            //Int32.TryParse(Console.ReadLine(), out _den);

        }

        public Fraction Plus(Fraction x2)               //Сложение дробей
        {
            Fraction x3 = new Fraction();
            x3.num = num * x2.den + x2.num * den;
            x3.den = den * x2.den;
            resnum = x3.num;                            //Переменная для доступа к числителю результата(для задяния с *)
            resden = x3.den;                            //Переменная для доступа к знаменателю результата(для задяния с *)
            double dresnum = Convert.ToDouble(resnum);
            double dresden = Convert.ToDouble(resden);
            doubres = dresnum / dresden;
                

            return x3;
        }

        public Fraction Minus(Fraction x2)              //Вычитание дробей
        {
            Fraction x3 = new Fraction();
            x3.num = num * x2.den - x2.num * den;
            x3.den = den * x2.den;
            resnum = x3.num;                            //Переменная для доступа к числителю результата(для задяния с *)
            resden = x3.den;                            //Переменная для доступа к знаменателю результата(для задяния с *)

            return x3;
        }

        public Fraction Multi(Fraction x2)              //Перемножение дробей
        {
            Fraction x3 = new Fraction();
            x3.num = num * x2.num;
            x3.den = den * x2.den;
            resnum = x3.num;                            //Переменная для доступа к числителю результата(для задяния с *)
            resden = x3.den;                            //Переменная для доступа к знаменателю результата(для задяния с *)
            return x3;
        }
        public Fraction Div(Fraction x2)              //Перемножение дробей
        {
            Fraction x3 = new Fraction();
            x3.num = num * x2.den;
            x3.den = den * x2.num;
            resnum = x3.num;                            //Переменная для доступа к числителю результата(для задяния с *)
            resden = x3.den;                            //Переменная для доступа к знаменателю результата(для задяния с *)
            return x3;
        }
        public string ToString()
        {
            return num + "/" + den;
        }

        public Fraction Reduc(Fraction x2)          //Метод для сокращения дробей
        {
            Fraction x3 = new Fraction();
            int min = Math.Min(x2.num,x2.den);
            x3.num = x2.num;
            x3.den = x2.den;

            for (int i = min; i>1; i--)
            {
                if (x2.num % i == 0 && x2.den % i == 0)
                {
                    x3.num = x2.num / i;
                    x3.den = x2.den / i;
                    break;
                }
            
            }

            return x3;
        }

    }

    class Program
    {


        static void Main()
        {
            Console.WriteLine("Введите числитель: ");
            int _num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите знаменатель: ");
            int _den = Convert.ToInt32(Console.ReadLine());
                if (_den == 0)
            {
                throw new System.ArgumentException("Знаменатель не может быть равен 0");
            }

            Fraction fraction1;
            fraction1 = new Fraction(_num, _den);

            Console.WriteLine("Введите числитель 2 дроби: ");
            _num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите знаменатель 2 дроби: ");
            _den = Convert.ToInt32(Console.ReadLine());
            if (_den == 0)
            {
                throw new System.ArgumentException("Знаменатель не может быть равен 0");
            }
            Fraction fraction2;
            fraction2 = new Fraction(_num,_den);
            Fraction result;
            result = fraction1.Plus(fraction2);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Демонстрация сложения");
            Console.WriteLine("Доступ через int к числителю: " + fraction1.resnum); 
            Console.WriteLine("Доступ через int к знаменателю: " + fraction1.resden);
            Console.WriteLine("Вывод десятичной дроби: " + fraction1.doubres);   //вывод десятичной дроби
            Console.WriteLine("Сам результат: " + result.ToString());
            Console.WriteLine();
            Console.WriteLine("Демонстрация вычитания");
            result = fraction1.Minus(fraction2);
            Console.WriteLine(result.ToString());
            Console.WriteLine();
            Console.WriteLine("Демонстрация умножения");
            result = fraction1.Multi(fraction2);
            Console.WriteLine(result.ToString());
            Console.WriteLine();
            Console.WriteLine("Демонстрация деления");
            result = fraction1.Div(fraction2);
            Console.WriteLine(result.ToString());

            Console.WriteLine();
            Console.WriteLine("Демонстрация сокращения дроби(Первой из введенных)");
            result = fraction1.Reduc(fraction1);
            Console.WriteLine(result.ToString());


        }
    }
}
