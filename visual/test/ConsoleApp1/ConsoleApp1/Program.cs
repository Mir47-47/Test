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
            String checkPalindrome = "aabaa";
            int count = checkPalindrome.Length;
            count = count % 2;
            if (count!=0&&count==0 ) //짝수라면
            {
            
            }
            else//짝수가 아니면
            {

            }
            return result;//result를 반환
        }
    }
} 
//char은 문자 하나씩만 받을수 있음 string 사용해도 결과는 같음