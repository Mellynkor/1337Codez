using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    public int solution(int N)
    {
        // Convert N into Vinary
        string Binary = Convert.ToString(N, 2);
        //Regex pattern to Match "10+1" formats
        string pattern = "10+1";
        string parse = "";
        int pointer = 0;
        var gap = 0;
        List<int> gaps = new List<int>();

        //Check for a regex match on the input binary, if not found output 0
        Match match = Regex.Match(Binary, pattern);
        if (!match.Success)
        {
            return 0;
        }
        else if (match.Success)
        {
            //Start at the first 1 in the binary string
            pointer = Binary.IndexOf('1');
            //Create a new substring based on the first found 1's position
            parse = Binary.Substring(pointer, Binary.Length);
            //Start to loop thru the substring
            for (int j = 0; j < parse.Length; j++)
            {
                //if the parse[j] value is a 0
                if (parse[j].Equals('0'))
                {
                    gap += 1;  //increment gap
                }
                //otherwise, if its a 1
                else if (parse[j].Equals('1'))
                {
                    gaps.Add(gap);// store the gap total
                    gap = 0; //reset the gap counter
                }
            }

        }

        return gaps.Max(); // return the maximum value from the gaps array
    }
}