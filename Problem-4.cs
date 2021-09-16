using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Dictionary<int, int> dist = new Dictionary<int, int>();
            string numbers;
            int[] a=new int[100];
            Console.WriteLine("Enter the numbers");
            numbers = Console.ReadLine();
            string[] num = numbers.Split(",");
            int len = num.Length;
            for(int i = 0; i < len; i++)
            {
                a[i] = int.Parse(num[i]);
               // Console.WriteLine(a[i]);
            }
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 0; j <len; j++) {
                
                    if ((a[j] % i) == 0)
                    {
                        count = count + 1;
                    }
                }
                dist.Add(i, count);
                count = 0;
            }
           foreach(var pair in dist)
            {
                Console.Write($"{pair.Key}: {pair.Value},");
            }
        }



        
    }
}
