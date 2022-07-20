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
        int positive = arr.Count(num => num > 0);
        int negative = arr.Count(num => num < 0);
        int zero = arr.Count(num => num == 0);

        double resultPositive = (double)positive / arr.Count();
        double resultNegative = (double)negative / arr.Count();
        double resultZero = (double)zero / arr.Count();

        Console.WriteLine(resultPositive.ToString("F6"));
        Console.WriteLine(resultNegative.ToString("F6"));
        Console.WriteLine(resultZero.ToString("F6"));
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
