using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int century=0;
            century = centuryFromYear(200);
             Console.WriteLine(century);           
            Console.ReadKey();
            //오늘은 여기까지? 네 네
        }
        static int centuryFromYear(int year)
        {
            int century = 0;
            int a;
            a = year % 100;
            if (a == 0)
            { century = year / 100; }
            else
            { century = year / 100 + 1; }
            return century;
        }
    }
} 