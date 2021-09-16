using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Enter two numbers:");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operation to be performed(+,-,*,/)");
            string k = Console.ReadLine();
            double result=0;

            if (k.Equals("+"))
                result = a + b;
            else if (k.Equals("-"))
                result = a - b;
            else if (k.Equals("*"))
                result = a * b;
            else if (k.Equals("/"))
                result = a / b;
            else
                Console.WriteLine("Error");
           Console.WriteLine(result);


        }
    }
}
