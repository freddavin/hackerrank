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

    public static string timeConversion(string completeTime)
    {
        string timeWithoutPeriod = completeTime.Substring(0, completeTime.Length - 2);
        string period = completeTime.Substring(completeTime.Length - 2, 2);

        List<int> timeSplited = SplitAndConvertTime(timeWithoutPeriod);
        int hours = timeSplited[0];
        int minutes = timeSplited[1];
        int seconds = timeSplited[2];

        if (period == "AM")
        {
            if (hours == 12)
                hours -= 12;
        }
        if (period == "PM")
        {
            if (hours != 12)
                hours += 12;
        }

        string timeConverted = $"{hours.ToString("00")}:{minutes.ToString("00")}:{seconds.ToString("00")}";
        return timeConverted;
    }

    public static List<int> SplitAndConvertTime(string timeWithoutPeriod)
    {
        return timeWithoutPeriod.Split(":").ToList().Select(n => Convert.ToInt32(n)).ToList();
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
