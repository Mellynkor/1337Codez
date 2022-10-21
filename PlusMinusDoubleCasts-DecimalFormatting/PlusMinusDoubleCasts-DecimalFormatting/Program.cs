using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        double zeroCount = 0;
        double positiveCount = 0;
        double negativeCount = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            switch (arr[i])
            {
                case 0:
                    zeroCount++;
                    break;

                case < 0:
                    negativeCount++;
                    break;

                case > 0:
                    positiveCount++;
                    break;


            }
        }

        double zRatio = (double)zeroCount / (double)arr.Count();
        double pRatio = (double)positiveCount / (double)arr.Count();
        double nRatio = (double)negativeCount / (double)arr.Count();

        Console.WriteLine(pRatio.ToString("0.######"));
        Console.WriteLine(nRatio.ToString("0.######"));
        Console.WriteLine(zRatio.ToString("0.######"));

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}