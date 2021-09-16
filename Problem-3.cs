using System;

namespace series2
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter a number!");
                int n, m = 1;
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                    n = n - 1;
                for (int i = 0; i < n; i++)
                {

                    Console.Write(m + " ");
                    m = m + 2;


                }
        }
    }
}
