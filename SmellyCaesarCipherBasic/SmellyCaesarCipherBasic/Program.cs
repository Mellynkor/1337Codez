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
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
        string encrypted = "";
        //string[] array = new string[100];       
        //array = s.Split('-');


        ///ADD CHECK TO SEE IF DICTIONARY DOES NOT CONTAIN CHARACTER FOR SPECIAL CHARACTERS, LIKE -, ', \, /, etc.
        Dictionary<char, int> cipherC = new Dictionary<char, int>();
        cipherC.Add('a', 1);
        cipherC.Add('b', 2);
        cipherC.Add('c', 3);
        cipherC.Add('d', 4);
        cipherC.Add('e', 5);
        cipherC.Add('f', 6);
        cipherC.Add('g', 7);
        cipherC.Add('h', 8);
        cipherC.Add('i', 9);
        cipherC.Add('j', 10);
        cipherC.Add('k', 11);
        cipherC.Add('l', 12);
        cipherC.Add('m', 13);
        cipherC.Add('n', 14);
        cipherC.Add('o', 15);
        cipherC.Add('p', 16);
        cipherC.Add('q', 17);
        cipherC.Add('r', 18);
        cipherC.Add('s', 19);
        cipherC.Add('t', 20);
        cipherC.Add('u', 21);
        cipherC.Add('v', 22);
        cipherC.Add('w', 23);
        cipherC.Add('x', 24);
        cipherC.Add('y', 25);
        cipherC.Add('z', 26);
        cipherC.Add('-', 50);


        Dictionary<int, char> cipherN = new Dictionary<int, char>();
        cipherN.Add(1, 'a');
        cipherN.Add(2, 'b');
        cipherN.Add(3, 'c');
        cipherN.Add(4, 'd');
        cipherN.Add(5, 'e');
        cipherN.Add(6, 'f');
        cipherN.Add(7, 'g');
        cipherN.Add(8, 'h');
        cipherN.Add(9, 'i');
        cipherN.Add(10, 'j');
        cipherN.Add(11, 'k');
        cipherN.Add(12, 'l');
        cipherN.Add(13, 'm');
        cipherN.Add(14, 'n');
        cipherN.Add(15, 'o');
        cipherN.Add(16, 'p');
        cipherN.Add(17, 'q');
        cipherN.Add(18, 'r');
        cipherN.Add(19, 's');
        cipherN.Add(20, 't');
        cipherN.Add(21, 'u');
        cipherN.Add(22, 'v');
        cipherN.Add(23, 'w');
        cipherN.Add(24, 'x');
        cipherN.Add(25, 'y');
        cipherN.Add(26, 'z');
        cipherN.Add(50, '-');

        int check = 0;
        int remainder = 0;
        bool containsKey = true;
        for (int i = 0; i < s.Length; i++)
        {
            try
            {
                check = cipherC[Char.ToLower(s[i])];
            }
            catch (KeyNotFoundException e)
            {
                encrypted += s[i];
            }
            if (Char.IsUpper(s[i]))
            {
                if (check + k > 26)
                {
                    if (check == 50)
                    {
                        encrypted += "-";
                    }
                    else
                    if (check != 50)
                    {
                        remainder = (check + k) - 26;
                        encrypted += Char.ToUpper(cipherN[remainder]);
                    }
                }
                else
                    encrypted += Char.ToUpper(cipherN[check + k]);
            }
            else
                if (check + k > 26)
            {
                if (check == 50)
                {
                    encrypted += "-";
                }
                else
                if (check != 50)
                {
                    remainder = (check + k) - 26;
                    encrypted += cipherN[remainder];
                }
            }
            else
                try
                {
                    encrypted += cipherN[check + k];
                }
                catch (KeyNotFoundException e)
                {
                    encrypted += s[i];
                }
        }
        return encrypted;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.caesarCipher(s, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
