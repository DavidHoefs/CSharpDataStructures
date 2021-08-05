using System.Collections;
using System.Collections.Generic;

namespace DataStructuresTest.DataStructures
{
    internal class ArrayStack<T> : IStack<T>
    {
        private readonly List<T> list = new List<T>();
        public int Count { get; private set; }

        public IEnumerator<T> GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public T Peek()
        {
            if (Count == 0)
            {
                return default(T);
            }

            return list[list.Count - 1];
        }

        public T Pop()
        {
            if (Count == 0)
            {
                throw new System.Exception("Empty Stack");
            }

            var result = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            Count--;
            return result;
        }

        public void Push(T item)
        {
            list.Add(item);
            Count++;
        }
    }
}