using System;
using static System.Console;
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
            int number; //랜덤 숫자 저장
            int buy; // 구매 할 개수 숫자 저장

            Console.Write("구매 할 로또의 개수를 구하시오 : ");
            buy = int.Parse(Console.ReadLine());

            while (buy-- != 0) {
                Random rand = new Random();
                for (int b = 5; b <= 6; b++)
                {
                    number = rand.Next(46);
                    Console.Write(number + " ");
                }
                Console.Write("\n");
            }
        }
    }
}