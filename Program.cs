using System;

namespace Open_Lab_03._01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[2, 3] { { 1, 1, 1 }, { 1, 1, 1 } };
            Console.WriteLine(array[1, 2]);
        }
    }
}