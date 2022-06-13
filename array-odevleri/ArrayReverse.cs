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
        if(n>=1 && n<=1000)
        {
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        int[] dizi = arr.ToArray();
        int kisitlama = 0;
            for(int i=0; i<dizi.Count(); i++)
            {
                if(dizi[i]>=1 && dizi[i]<=10000)
                {
                    kisitlama++;
                }
            }
            if(kisitlama == dizi.Count())
            {
                Array.Reverse(dizi);
                for(int k=0; k<dizi.Count(); k++)
                {
                    Console.Write($"{dizi[k]} ");
                }
                
            } 
        }

    }
}
