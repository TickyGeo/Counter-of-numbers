using System;
using System.Globalization;
using System.Net.NetworkInformation;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint oddNum = 0;
            uint evenNum = 0;

            int oddNumSum = 0;
            int evenNumSum = 0;

            Console.WriteLine("Первое число диапозона");
            int curNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Второе число диапозона");
            int maxNum = int.Parse(Console.ReadLine());

            while (curNum <= maxNum)
            {

                if (curNum % 2 == 0)
                {
                    evenNum++;
                    evenNumSum += curNum;
                }
                else if (curNum % 2 != 0)
                {
                    oddNum++;
                    oddNumSum = curNum;
                };

                curNum++;
            };
                    Console.WriteLine("Odd nums count: " + oddNum);
                    Console.WriteLine("Even nums count: " + evenNum);
                    Console.WriteLine("Sum of odd nums: " + oddNumSum);
                    Console.WriteLine("Sum of even nums: " + evenNumSum);
                    Console.ReadLine();

        }
    }
}
