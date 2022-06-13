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
    public static int toplama(List<int> ar)
    {
        int[] dizi = ar.ToArray();
        int adet = dizi.Count();
        int total=0;
        for(int i=0;i<adet;i++)
        {
            if(dizi[i]>0 && dizi[i]<=1000)
            {
            total += dizi[i];
            }
        }
        return total;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int arCount = Convert.ToInt32(Console.ReadLine().Trim());
        if(arCount>0 && arCount<=1000)
        {
        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
        int sonuc = Convert.ToInt32(Result.toplama(ar));
        Console.WriteLine($"{sonuc}");
        }
    }
}