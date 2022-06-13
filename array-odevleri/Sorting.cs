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



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
        int[] dizi = a.ToArray();
        int[] yedekdizi = new int[n];
        int numberOfSwaps = 0;
        for (int i = 0; i < dizi.Count(); i++) 
        {
            for (int j = 0; j < (dizi.Count() - 1); j++) 
            {
                if (dizi[j] > dizi[j + 1]) 
                {
                    yedekdizi[j] = dizi[j];
                    dizi[j] = dizi[j+1];
                    dizi[j+1] = yedekdizi[j];
                    numberOfSwaps++;
                }
            }
        }
        Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
        Console.WriteLine($"First Element: {dizi[0]}");
        Console.WriteLine($"Last Element: {dizi[n-1]}");
    }
}
