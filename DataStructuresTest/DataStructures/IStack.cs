using System.Collections.Generic;

namespace DataStructuresTest.DataStructures
{
    internal interface IStack<T> : IEnumerable<T>
    {
        int Count { get; }

        T Pop();

        void Push(T item);

        T Peek();
    }
}