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
     * Complete the 'maximumPerimeterTriangle' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY sticks as parameter.
     */

    public static List<int> maximumPerimeterTriangle(List<int> sticks)
    {
        int[] maxSticksTriangle = new int[] { -1 };
        long sumMaxSticksTriagle = -1;
        for (int i = 0; i < sticks.Count; i++)
        {
            for (int j = i + 1; j < sticks.Count; j++)
            {
                for (int k = j + 1; k < sticks.Count; k++)
                {
                    long fisrtStick = sticks[i];
                    long secondStick = sticks[j];
                    long thirdStick = sticks[k];

                    if (fisrtStick + secondStick > thirdStick &&
                        fisrtStick + thirdStick > secondStick &&
                        secondStick + thirdStick > fisrtStick)
                    {
                        long sumSticks = fisrtStick + secondStick + thirdStick;
                        if (sumSticks > sumMaxSticksTriagle)
                        {
                            sumMaxSticksTriagle = sumSticks;
                            maxSticksTriangle = new int[] { (int)fisrtStick, (int)secondStick, (int)thirdStick };
                        }
                    }

                }
            }
        }
        return maxSticksTriangle.ToList().OrderBy(n => n).ToList();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> sticks = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sticksTemp => Convert.ToInt32(sticksTemp)).ToList();

        List<int> result = Result.maximumPerimeterTriangle(sticks);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
