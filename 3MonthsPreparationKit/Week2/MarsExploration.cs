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
     * Complete the 'marsExploration' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int marsExploration(string str)
    {
        List<string> dividedStr = new List<string>();
        for (int i = 0; i < str.Length; i += 3)
        {
            dividedStr.Add(str.Substring(i, 3));
        }

        int lettersChanged = 0;
        foreach (string word in dividedStr)
        {
            Console.WriteLine(word);
            if (word[0] != 'S')
            {
                lettersChanged++;
            }
            if (word[1] != 'O')
            {
                lettersChanged++;
            }
            if (word[2] != 'S')
            {
                lettersChanged++;
            }
        }

        return lettersChanged;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int result = Result.marsExploration(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
