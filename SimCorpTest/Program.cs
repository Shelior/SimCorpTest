using ListLibrary;
using System;

namespace SimCorpTest // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList list = new DoubleLinkedList();
            list.Add("one");
            list.Add("two");
            list.Add("three");
            list.Add("four");
            list.Add("five");
            list.Add("six");
            list.Add("seven");
            list.Add("eight");
            list.Add("nine");
            list.Add("ten");

            list.Delete("eleven");

            var y = list.ToArray();
        }
    }
}