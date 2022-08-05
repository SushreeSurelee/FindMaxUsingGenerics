using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxValue
{
    class GenericForFindMax<T> where T : IComparable
    {
        public T[] values;
        public GenericForFindMax(T[] values)
        {
            this.values=values;
        }
        public T[] sortingValues(T[] values)
        {
            Array.Sort(values); //inbuilt method to of collections
            return values;
        }
        public T FindMaxValue(params T[] values)
        {
            var sortedValues = sortingValues(values);
            return sortedValues[values.Length-1];
        }
        public void PrintMaximumValue()
        {
            var maxValue = FindMaxValue(this.values);
            Console.WriteLine("The maximum value is : "+ maxValue);
        }
    }
}
