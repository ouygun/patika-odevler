using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) 
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        List<string> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToString(arrTemp)).ToList();
        string[] dizi = arr.ToArray();
        for(int i=0; i<n;i+=2)
        {
            for(int j=0; j<n;j++)
            {
                Console.WriteLine($"{dizi[j]}");
            }
        }
        Console.ReadLine();
    }
}
