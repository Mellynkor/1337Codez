using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        var sint = 0;
        if (A.Max() <= 0) // Check if Maximum value of array is < 0, if so we know to immediately return a 1
        {
            return 1;
        }
        if (A.Min() < 0) //Check if the Minimum value is < 0, if it is, we assign sint the value of 0 for further processing
        {
            sint = 0;
        }
        if (!A.Contains(sint + 1)) //Check to see if A DOES NOT contain sint + 1, ie ; minimum + 1; if it doesnt, immediately return it
        {
            return sint + 1;
        }
        for (int i = 0; sint < A.Max(); i++) //Begin for loop, iterating while sint < A's Max value
        {
            if (!A.Contains(A.Min() + i) && A.Min() > 0) //If A DOES NOT contain it's minimum value + i, AND the minimum is > 0
            {
                sint = A.Min() + i; //Set sint = A's minimum + i
                return sint; //return sint
            }
            else
                for (int j = A.Max(); j > 0; j--) //Secondary inverted nested loop, starting at A's max value; decrementing towards 0
                {
                    sint = A.Max(); //set sint = A's max value
                    sint -= j; // Decrement sint by j
                    if (sint < A.Max() && sint > 0 && !A.Contains(sint)) //Check if sint is less than A's Max AND sint > 0, AND A DOES NOT contain sint already
                    {
                        return sint; //return sint
                    }
                }
        }
        return sint; //closing return
    }
}
