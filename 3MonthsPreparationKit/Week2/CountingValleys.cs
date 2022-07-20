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
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string stringPath)
    {
        var path = new List<int>();
        foreach (char c in stringPath)
        {
            if (c == 'U')
            {
                path.Add(1);
            }
            else
            {
                path.Add(-1);
            }
        }

        bool isInsideValley = false;
        int countValley = 0;
        int stepsPath = 0;
        foreach (var step in path)
        {
            stepsPath += step;
            if (stepsPath < 0 && !isInsideValley)
            {
                countValley++;
                isInsideValley = true;
            }
            if (stepsPath == 0 && isInsideValley)
            {
                isInsideValley = false;
            }

        }

        return countValley;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int steps = Convert.ToInt32(Console.ReadLine().Trim());

        string path = Console.ReadLine();

        int result = Result.countingValleys(steps, path);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
