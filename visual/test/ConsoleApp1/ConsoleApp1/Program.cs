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
            bool result;
            result = checkPalindrome("aabaa");
            Console.WriteLine(result);
        }
        static bool checkPalindrome(string inputString)
        {
            bool result = false;
            //검사 로직 구현
            return result;
        }
    }
} 
//char은 문자 하나씩만 받을수 있음 string 사용해도 결과는 같음