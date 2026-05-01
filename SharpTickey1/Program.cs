using System;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = int.Parse(Console.ReadLine());

  
            int res = x % 2;

            bool isEven = res == 0;
            
            string month;

            month = Console.ReadLine();

            if (isEven && (month == "July" || month == "June" || month == "August")) {
                Console.WriteLine("Hot summer boy");
            } else
            {
                Console.WriteLine("okk");
            }
        }
    }
}
