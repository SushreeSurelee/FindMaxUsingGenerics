using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxValue
{
    class GenericForFindMax<T> where T : IComparable
    {
        public T first, second, third;
        public GenericForFindMax(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public static T FindMaxValue(T first, T second, T third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("\nFirst value is greater");
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("\nSecond value is greater");
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine("\nThird value is greater");
                return third;
            }
            else
            {
                Console.WriteLine("2 or 3 of the given integer might be having same value.");
                return default;
            }
        }
        public void TestMax()
        {
            var maxValue = FindMaxValue(first, second, third);
            Console.WriteLine("{0} is the maximum value out of {1} {2} {3}", maxValue,first,second,third);
        }
    }
}
