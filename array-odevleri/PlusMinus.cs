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
    public static void hesap(List<int> arr)
    {
        int[] dizi = arr.ToArray();
        int adet = dizi.Count();
        int positive = 0, negative = 0, zero=0;
        for(int i=0;i<adet;i++)
        {
            if(dizi[i]>=-100 && dizi[i]<=100)
            {
                if(dizi[i]>0)
                {
                    positive++;
                }
                else if(dizi[i]<0)
                {
                    negative++;
                }
                else
                {
                    zero++;
                }
            }
        }
        double pratio = Convert.ToDouble(positive) / Convert.ToDouble(adet);
        double nratio = Convert.ToDouble(negative) / Convert.ToDouble(adet);
        double zratio = Convert.ToDouble(zero) / Convert.ToDouble(adet);
        Console.WriteLine($"{pratio.ToString("N6")}");
        Console.WriteLine($"{nratio.ToString("N6")}");
        Console.WriteLine($"{zratio.ToString("N6")}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        if(n>0 && n <=100)
        {
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        Result.hesap(arr);
        }
        else
        {
            Console.WriteLine("Out of range");
        }
        Console.ReadLine();
    }
}
