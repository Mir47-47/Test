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
            century = centuryFromYear(1);
             Console.WriteLine(century);           
            Console.ReadKey();
            //오늘은 여기까지? 네 네
        }
        static int centuryFromYear(int year)
        {
            if (year >= 1 && year <= 99)
            {

            }
            if (year >= 100 && year <= 999)
            {

            }
            if (year >= 1000 && year <= 2005)
            {

            }
            return 0;
        }
    }
}
