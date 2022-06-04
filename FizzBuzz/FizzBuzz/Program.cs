using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            FizzBuzz(15);
            IList<string> FizzBuzz(int n)
            {

                string[] answer = new string[n];

                for (int i = 1; i <= n; i++) //Iterate while less than and = to n
                {
                    if (i % 3 == 0 && i % 5 == 0) //Check if i is divisible by both 3 and 5
                    {
                        answer[i - 1] = "FizzBuzz"; //If it is, set answer index-1 to FizzBuzz
                    }
                    else
                    if (i % 3 == 0) //if i is divisible by 3
                    {
                        answer[i - 1] = "Fizz"; //Set answer index-1 to Fizz
                    }
                    else
                        if (i % 5 == 0) //Else, if its divisible by 5
                    {
                        answer[i - 1] = "Buzz"; //Set answer index-1 to Buzz
                    }
                    else answer[i - 1] = i.ToString();
                }

                return answer;
            }
        }
    }
}

