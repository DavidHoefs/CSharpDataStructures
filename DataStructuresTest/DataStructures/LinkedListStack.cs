using DataStructuresTest.DataStructures.LinkedList;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructuresTest.DataStructures
{
    internal class LinkedListStack<T> : IStack<T>
    {
        private readonly SinglyLinkedList<T> list = new SinglyLinkedList<T>();
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
            return Count == 0 ? default(T) : list.Head.Data;
        }

        public T Pop()
        {
            if (Count == 0)
            {
                throw new Exception("Empty Stack");
            }

            var result = list.DeleteFirst();
            Count--;
            return result;
        }

        public void Push(T item)
        {
            list.InsertFirst(item);
            Count++;
        }
    }
}