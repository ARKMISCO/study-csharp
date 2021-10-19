using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            Console.WriteLine("몇단? : ");
            A = int.Parse(Console.ReadLine());

            for (int B = 1; B < 10; ++B)
            {
                Console.WriteLine($"{A}*{B}:{A * B}");
            }
        }
    }
}
