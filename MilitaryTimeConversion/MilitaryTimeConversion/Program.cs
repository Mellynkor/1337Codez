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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        char tt = '.';
        if (s[s.Length - 2].Equals('P'))
        {
            tt = 'P';
        }
        if (s[s.Length - 2].Equals('A'))
        {
            tt = 'A';
        }
        s = s.Remove(s.Length - 2, 2);
        DateTime time = DateTime.ParseExact(s, "HH:mm:ss", CultureInfo.InvariantCulture);
        if (tt.Equals('P') && time.Hour != 12)
        {
            time = time.AddHours(12);
        }
        string tHr = time.Hour.ToString();
        int stringCutter = time.ToString().IndexOf(' ');
        if (tt.Equals('A') && tHr.Equals("12"))
        {
            return time.AddHours(-12).ToString().Substring(stringCutter).Trim();
        }


        //
        return time.ToString().Substring(stringCutter).Trim();

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
