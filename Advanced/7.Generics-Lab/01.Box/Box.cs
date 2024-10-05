using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    public class Box<T>
    {
        public Stack<T> elements;

        public int Count { get; private set; }
        public Box()
        {
            this.elements = new Stack<T>();
        }

        public void Add(T element)
        {
            elements.Push(element);
            Count++;
        }

        public T Remove()
        {
            Count--;
            return elements.Pop();
        }
    }
}
