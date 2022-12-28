using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

//P INDEX # must be LESS THAN Q INDEX #
//Q[INDEX VALUE] MUST BE LESS THAN P[INDEX VALUE]

//EX. 1,2  (P=1, < Q=2)  && P[6] > Q[3] 
class Solution
{
    static void Main(string[] args)
    {
        int[] A = new int[] { -1, 6, 3, 4, 7, 4 };
        solution(A);
    }
    static int solution(int[] A)
    {

        var inversions = 0;
        var pindex = 0;
        var qindex = 0;
        var qvalue = 0;
        var pvalue = 0;

        //Conditions to check for truths
        // pvalue = A[1];
        //pindex = 6;

        //pvalue = A[1]; // 6//
        //pindex = 1; // 1

        //EX TRUTH pindex1 < qindex2 && (qvalue3 < 6pvalue,)

        //Positive loop for Ps
        for (int i = 0; i < A.Length-1; i++)
        {
            pvalue = A[i];
            pindex = i;

            //Inverted Loop for Qs
            for (int j = A.Length - 1; j > 0; j--)
            {
                qvalue = A[j];
                qindex = j;
                //Console.WriteLine(pvalue + " " + qvalue);

                if (pindex < qindex && qvalue < pvalue)
                {
                    //Console.WriteLine(pindex + " " + qindex);
                    inversions++;
                }
            }
        }
        if (inversions > 1000000000)
        {
            return -1;
        }
        else
            return inversions;
        // Console.ReadKey();
    }
}

/*
 * using System;
using System.Collections;
//EX. 1,2  (P=1, < Q=2)  && P[6] > Q[3] 
class Solution
{
    public int solution(int[] A)
    {

        var inversions = 0;
        var pindex = 0;
        var qindex = 0;
        var qvalue = 0;
        var pvalue = 0;

        //EX TRUTH pindex1 < qindex2 && (qvalue3 < 6pvalue,)

        //Positive loop for Ps
        for (int i = 0; i < A.Length-1; i++)
        {
            pvalue = A[i];
            pindex = i;

            //Inverted Loop for Qs
            for (int j = A.Length - 1; j > 0; j--)
            {
                qvalue = A[j];
                qindex = j;
                //Console.WriteLine(pvalue + " " + qvalue);

                if (pindex < qindex && qvalue < pvalue)
                {
                    //Console.WriteLine(pindex + " " + qindex);
                    inversions++;
                }
            }
        }
        if (inversions > 1000000000)
        {
            return -1;
        }
        else
        return inversions;
       // Console.ReadKey();
    }
}

 */