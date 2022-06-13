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
    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int[] alice = a.ToArray();
        int[] bob = b.ToArray();
        int pointa = 0; 
        int pointb = 0;
        for(int i = 0; i<alice.Count();i++)
        {
            if(alice[i]>=1 && alice[i]<=100 && bob[i]>=1 && bob[i]<=100)
            {
                if(alice[i]<bob[i])
                {
                    pointb++;
                }
                else if(alice[i]>bob[i])
                {
                    pointa++;
                }
                else
                {
                    //Ekleme olmayacak.
                }
            }
        }
        List<int> cevap = new List<int>();
        cevap.Add(pointa);
        cevap.Add(pointb);
        return cevap;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = Result.compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
