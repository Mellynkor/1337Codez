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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        long min = 0;
        long max = 0;
        long sum = 0;
        int j = 0;

        do
        {
            sum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                sum += arr[i];
            }
            sum -= arr[j];
            if (j == 0)
            {
                min = sum;
                max = sum;
            }
            if (sum < min)
            {
                min = sum;
            }
            if (sum > max)
            {
                max = sum;
            }
            j++;
        } while (j < arr.Count);

        Console.Write(min + " " + max);

    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
