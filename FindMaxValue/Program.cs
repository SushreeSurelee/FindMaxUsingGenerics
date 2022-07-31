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
            Console.WriteLine("\n1:Find maximum number for integer values");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("\nEnter the First, Second and Third Integer value in below line.");
                    int first = Convert.ToInt32(Console.ReadLine());
                    int second = Convert.ToInt32(Console.ReadLine());
                    int third = Convert.ToInt32(Console.ReadLine());
                    int max = FindMaximumValue.FindMaxValue(first, second, third);
                    if(max!=0)
                    Console.WriteLine("{0} is the maximum value out of {1} {2} {3}", FindMaximumValue.FindMaxValue(first, second, third),first,second,third);
                    break;
            }
            Console.ReadLine();
         }   
                
    }
}
