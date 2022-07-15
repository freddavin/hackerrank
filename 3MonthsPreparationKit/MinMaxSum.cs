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

class MinMaxSum
{
    public static void Solution()
    {
        List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();
        Result(arr);
    }

    public static void Result(List<long> arr)
    {
        var orderArr = arr.OrderBy(n => n);

        var min = orderArr.Sum() - orderArr.Last();
        var max = orderArr.Sum() - orderArr.First();

        Console.WriteLine(min + " " + max);
    }
}
