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
    public static int migratoryBirds(List<int> arr)
    {
        int[] dizi = arr.ToArray();
        int[] tip = {0, 0, 0, 0, 0, 0};
        for(int i = 1;i<=5;i++)
        {
            for(int k=0;k<dizi.Count();k++)
            {
                if(dizi[k]==i)
                {
                    tip[i]++;
                }
            }
        }
        int maksimum = 1;
        int adet = tip[1];
        for(int j=2;j<=5;j++)
        {
            if(adet<tip[j])
            {
                maksimum=j;
                adet=tip[j];
            }
        }
        return maksimum;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
