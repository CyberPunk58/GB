using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1E4
{
    class Program
    {
        static void Main()
        {
            /*Андреев Павел
             * Написать программу обмена значениями двух переменных:
             *  а) с использованием третьей переменной;
	         *  б) *без использования третьей переменной.
             * 
             * 
             */

            int a, b, c, d, e, f, g;
            //С использованием третьей переменной.
            a = 1;
            b = 2;
            c = a;
            a = b;
            b = c;
           
            Console.WriteLine($"a = {a}, b = {b}");
            ///////////////
            
            //Без использования третьей, но для чисельных переменных.

            d = 3;
            e = 5;

            d = d + e;
            e = d - e;
            d = d - e;

            Console.WriteLine($"d = {d}, e = {e}");
            ///////////////

            //Еще без использования третьей переменной   
            f = 10;
            g = 20;

            f ^= g;
            g ^= f;
            f ^= g;

            Console.WriteLine($"f = {f}, g = {g}");
        }
    }
}
