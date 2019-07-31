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
            int count1;
            /*while (a==count)
            {
                s1
            보류*/
            char s1 = checkPalindrome[0];
            char s2 = checkPalindrome[1];
            char s3 = checkPalindrome[2];
            char s4 = checkPalindrome[3];
            char s5 = checkPalindrome[4];
            Console.WriteLine(s1);
            Console.WriteLine(s3);
            count1 = count % 2;
            if (count!=0&&count1==0 ) //짝수라면
            {
                /*Console.WriteLine("짝수다");*/
            }
            else//짝수가 아니면
            {
                /*Console.WriteLine("홀수다");*/
            }
            return result;//result를 반환
        }
    }
} 
//char은 문자 하나씩만 받을수 있음 string 사용해도 결과는 같음