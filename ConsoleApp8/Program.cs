using System;
using static System.Console;
using System.Text;
using System.IO;

namespace baekjoon
{
    class MainApp
    {
        static void Main()
        {
            for (int a = 1; a < 10; a++)
            {
                for (int b = 0; b < a; b++)
                    Console.Write("★");
                Console.Write("\n");
            }
                //Console.WriteLine(a);
        }
    }
}