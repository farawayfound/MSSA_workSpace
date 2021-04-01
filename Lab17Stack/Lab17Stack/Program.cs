using System;

namespace Lab17Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myInts = new Stack<int>(10);
            myInts.Push(99);
            myInts.Push(-20);


            IntStack tenInts = new IntStack(10);
            tenInts.Push(12);
            tenInts.Push(-1);
            tenInts.Push(3);
        }
    }
}
