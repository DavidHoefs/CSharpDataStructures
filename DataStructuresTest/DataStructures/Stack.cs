using System.Collections;
using System.Collections.Generic;

namespace DataStructuresTest.DataStructures
{
    public class Stack<T> : IEnumerable<T>
    {
        private readonly IStack<T> stack;

        public int Count => stack.Count;

        public Stack(StackType type = StackType.Array)
        {
            if (type == StackType.Array)
                stack = new ArrayStack<T>();
            else
                stack = new LinkedListStack<T>();
        }

        public T Pop()
        {
            return stack.Pop();
        }

        public void Push(T item)
        {
            stack.Push(item);
        }

        public T Peek()
        {
            return stack.Peek();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return stack.GetEnumerator();
        }

        public enum StackType
        {
            Array = 0,
            LinkedList = 1
        }
    }
}