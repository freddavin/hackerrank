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
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> roundingGrades = new List<int>();

        foreach (var grade in grades)
        {
            if (grade < 38)
            {
                roundingGrades.Add(grade);
            }
            else
            {
                for (int i = 1; i <= 5; i++)
                {
                    var roundGrade = grade + i;
                    if (roundGrade % 5 == 0 && roundGrade - grade < 3)
                    {
                        roundingGrades.Add(roundGrade);
                    }
                    else if (roundGrade % 5 == 0 && roundGrade - grade >= 3)
                    {
                        roundingGrades.Add(grade);
                    }
                }
            }
        }

        return roundingGrades;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
