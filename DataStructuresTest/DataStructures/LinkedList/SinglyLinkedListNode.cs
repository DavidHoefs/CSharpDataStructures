namespace DataStructuresTest.DataStructures.LinkedList
{
    public partial class SinglyLinkedList<T>
    {
        public class SinglyLinkedListNode<T>
        {
            public SinglyLinkedListNode<T> Next;
            public T Data;

            public SinglyLinkedListNode(T data)
            {
                Data = data;
            }
        }
    }
}