using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodDouble
{
    public class Box<T> where T: IComparable
    {
        private T[] items;
        private T value;

        public Box(T[] items, T value)
        {
            this.items = items;
            this.value = value;
        }
        
        public int ReturnTheCountOfGreaterElements()
        {
            int count = 0;

            foreach (T item in items)
            {
                if (item.CompareTo(value) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
