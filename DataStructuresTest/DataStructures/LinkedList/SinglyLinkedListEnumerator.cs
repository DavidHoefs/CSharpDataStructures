using System.Collections;
using System.Collections.Generic;

namespace DataStructuresTest.DataStructures.LinkedList
{
    public partial class SinglyLinkedList<T>
    {
        internal class SinglyLinkedListEnumerator<T> : IEnumerator<T>
        {
            internal SinglyLinkedListNode<T> HeadNode;
            internal SinglyLinkedListNode<T> CurrentNode;

            internal SinglyLinkedListEnumerator(ref SinglyLinkedListNode<T> headNode)
            {
                HeadNode = headNode;
            }

            public T Current { get { return CurrentNode.Data; } }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                HeadNode = null;
                CurrentNode = null;
            }

            public bool MoveNext()
            {
                if (HeadNode == null)
                    return false;

                if (CurrentNode == null)
                {
                    CurrentNode = HeadNode;
                    return true;
                }

                if (CurrentNode.Next != null)
                {
                    CurrentNode = CurrentNode.Next;
                    return true;
                }

                return false;
            }

            public void Reset()
            {
                CurrentNode = HeadNode;
            }
        }
    }
}