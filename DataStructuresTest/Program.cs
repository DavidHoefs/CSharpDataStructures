using DataStructuresTest.DataStructures;
using System;

namespace DataStructuresTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            LinkedListStack<int> listStack = new LinkedListStack<int>();
            for (int i = 0; i < 10000; ++i)
            {
                listStack.Push(i);

            }

            while (listStack.Count > 0)
            {
                Console.WriteLine(listStack.Pop());
            }
        }
    }
}