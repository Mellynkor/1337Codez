using System;
/*
    Do this until A and B are depleted (Decrement each run?)
    Place 2 at a time, alternate
    
*/
class Solution
{
    public string solution(int A, int B)
    {
        string r = "";
        char c = 'a';
        if (A != 1 && B != 1 && A - B > 1 && B - A > 1)
        {
            while (A > 0 || B > 0)
            {
                if (c.Equals('a'))
                {
                    if (A > 1)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            r += "a";
                            A--;
                        }
                    }
                    else
                    {
                        r += "a";
                        A--;
                    }
                    c = 'b';
                }
                else if (c.Equals('b'))
                {
                    if (B > 1)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            r += "b";
                            B--;
                        }
                    }
                    else
                    {
                        r += "b";
                        B--;
                    }
                    c = 'a';
                }
            }
        }
        else
        {
            if (A == 1 || A == 0)
            {
                c = 'b';
            }
            else if (B == 1 || B == 0)
            {
                c = 'a';
            }
            while (A > 0 || B > 0)
            {
                if (c.Equals('a'))
                {
                    if (A > 1 && A + 1 != B && B / A != 2 && A % 2 != 1)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            r += "a";
                            A--;
                        }
                    }
                    else
                    {
                        r += "a";
                        A--;
                    }
                    c = 'b';
                }
                else if (c.Equals('b'))
                {
                    if (B > 1 && B + 1 != A && A / B != 2 && B % 2 != 1)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            r += "b";
                            B--;
                        }
                    }
                    else
                    {
                        r += "b";
                        B--;
                    }
                    c = 'a';
                }
            }
        }
        return r;
    }
}

