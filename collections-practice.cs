using System;
using System.Collections.Generic;
using System.IO;


namespace TrainingJan21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Int32> obj = new Stack<Int32>();
            obj.Push(10);
            obj.Push(11);
            obj.Push(12);
            obj.Push(13);
            obj.Push(14);
            obj.Push(15);
            foreach(int item in obj)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
