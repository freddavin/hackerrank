using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Solution
{
    static void convertCamelCase(List<string> inputCollection)
    {
        foreach (var input in inputCollection)
        {
            string[] inputDivided = input.Split(";");

            if (inputDivided[0] == "C")
            {
                Console.WriteLine(Combine(inputDivided[2], inputDivided[1]));
            }
            else if (inputDivided[0] == "S")
            {
                Console.WriteLine(Split(inputDivided[2], inputDivided[1]));
            }
        }
    }

    static string Combine(string inputDivided, string type)
    {
        StringBuilder sb = new StringBuilder();

        bool makeUpperCase = false;
        if (type == "C")
        {
            makeUpperCase = true;
        }

        foreach (char c in inputDivided)
        {
            if (c == ' ')
            {
                makeUpperCase = true;
                continue;
            }
            else if (makeUpperCase)
            {
                sb.Append(char.ToUpper(c));
                makeUpperCase = false;
            }
            else
            {
                sb.Append(c);
            }
        }

        if (type == "M")
        {
            sb.Append("()");
        }

        return sb.ToString();
    }

    static string Split(string inputDivided, string type)
    {
        var sb = new StringBuilder();
        foreach (char c in inputDivided)
        {
            if (char.IsUpper(c) && sb.Length != 0)
            {
                sb.Append(' ');
            }
            sb.Append(char.ToLower(c));
        }
        if (type == "M")
        {
            sb.Remove(sb.Length - 2, 2);
        }
        return sb.ToString();
    }

    static void Main(String[] args)
    {
        List<string> input = new List<string>();
        string inputLine;
        while (!String.IsNullOrWhiteSpace(inputLine = Console.ReadLine()))
        {
            input.Add(inputLine);
        }
        convertCamelCase(input);

    }
}
