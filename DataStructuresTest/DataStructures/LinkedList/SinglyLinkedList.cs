using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructuresTest.DataStructures.LinkedList
{
    public partial class SinglyLinkedList<T> : IEnumerable<T>
    {
        public SinglyLinkedListNode<T> Head;

        public void InsertFirst(T data)
        {
            var newNode = new SinglyLinkedListNode<T>(data);
            newNode.Next = Head;
            Head = newNode;
        }

        public void InsertLast(T data)
        {
            var newNode = new SinglyLinkedListNode<T>(data);

            if (Head == null)
            {
                Head = new SinglyLinkedListNode<T>(data);
            }
            else
            {
                var current = Head;

                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }

        public T DeleteFirst()
        {
            if (Head == null)
            {
                throw new Exception("Nothing to remove in List");
            }

            var firstData = Head.Data;

            Head = Head.Next;

            return firstData;
        }

        public T DeleteLast()
        {
            if (Head == null)
            {
                throw new Exception("Nothing to remove in list");
            }

            var current = Head;
            SinglyLinkedListNode<T> previous = null;

            while (current.Next != null)
            {
                previous = current;
                current = current.Next;
            }

            var lastData = previous.Next.Data;
            previous.Next = null;
            return lastData;
        }

        public void Delete(T element)
        {
            if (Head == null)
            {
                throw new Exception("The list is empty");
            }

            var current = Head;
            SinglyLinkedListNode<T> prev = null;

            do
            {
                if (current.Data.Equals(element))
                {
                    if (current.Next == null)
                    {
                        if (prev == null)
                        {
                            Head = null;
                        }
                        else
                        {
                            prev.Next = null;
                        }
                    }
                    else
                    {
                        if (prev == null)
                        {
                            Head = current.Next;
                        }
                        else
                        {
                            prev.Next = current.Next;
                        }
                    }

                    break;
                }

                prev = current;
                current = current.Next;
            } while (current != null);
        }

        public bool IsEmpty() => Head == null;

        public void Clear()
        {
            if (Head == null)
            {
                throw new Exception("The list is empty");
            }

            Head = null;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new SinglyLinkedListEnumerator<T>(ref Head);
        }
    }
}