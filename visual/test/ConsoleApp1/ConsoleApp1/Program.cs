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
            int/* a=1,b=0,*/count1;
            /*while (a==count)
            {
                char s%a = checkPalindrome[b];
                a++;
            }
            보류*/
            char s1 = checkPalindrome[0];
            char s2 = checkPalindrome[1];
            char s3 = checkPalindrome[2];
            char s4 = checkPalindrome[3];
            char s5 = checkPalindrome[4];
            //char s6 = checkPalindrome[5];
            count1 = count % 2;
            if (count!=0&&count1==0 ) //짝수라면
            {
                if (s1 == s5)
                {
                    if (s2 == s4)
                    {
                        result = true;
                    }


                    else
                    {
                        result = false;
                    }
                }
                else
                {
                   result = false;
                }
                /*Console.WriteLine("짝수다");*/
            }
            else//짝수가 아니면
            {
                /*if (s1 == s6)
                {
                    if (s2 == s5)
                    {
                        if(s3==s4)
                        {

                        }
                        else
                        {
                            result = false;
                        }
                    }
                    else
                    {
                        result = false;
                    }
                }
                else
                {
                    result = false;
                }
                /*Console.WriteLine("홀수다");*/
            }
            return result;//result를 반환
        }
    }
} 
//char은 문자 하나씩만 받을수 있음 string 사용해도 결과는 같음