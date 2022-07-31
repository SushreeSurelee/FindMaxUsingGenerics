using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxValue
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Wlcome to Find maximum number Application.");
            Console.WriteLine("\nPlease choose number as shown below to find maximum value");
            Console.WriteLine("\n1:Find maximum number for Integer values\n2.Find maximum number for Float values");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("\nEnter the First, Second and Third Integer value in below line.");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    int c = Convert.ToInt32(Console.ReadLine());
                    int maxInt = FindMaximumValue.FindMaxValue(a, b, c);
                    if(maxInt!=0)
                    Console.WriteLine("{0} is the maximum value out of {1} {2} {3}", FindMaximumValue.FindMaxValue(a, b, c),a,b,c);
                    break;
                case 2:
                    Console.WriteLine("\nEnter the First, Second and Third Integer value in below line.");
                    float d = Convert.ToSingle(Console.ReadLine());
                    float e = Convert.ToSingle(Console.ReadLine());
                    float f = Convert.ToSingle(Console.ReadLine());
                    float maxFloat = FindMaximumValue.FindMaxValue(d, e, f);
                    if (maxFloat != 0)
                        Console.WriteLine("{0} is the maximum value out of {1} {2} {3}", FindMaximumValue.FindMaxValue(d, e, f), d, e, f);
                    break;
            }
            Console.ReadLine();
         }   
    }
}
