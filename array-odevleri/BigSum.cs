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
    public static long aVeryBigSum(List<long> ar)
    {
        long[] dizi = ar.ToArray();
        long toplam = 0;
        double maksimum = Math.Pow(10,10);
        for(int i=0;i<dizi.Count();i++)
        {
            if(dizi[i]>=0 && dizi[i]<=maksimum)
            {
                toplam += dizi[i];
            }
        }
        return toplam;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine().Trim());
        if(arCount>=1 && arCount<=10)
        {
                    List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

        long result = Result.aVeryBigSum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
        }
    }
}
