using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calc_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstVal, secondVal;
                string action; 
                try
                {

                    Console.WriteLine("Number 1");
                    firstVal = double.Parse(Console.ReadLine());    

                    Console.WriteLine("Number 2");
                    secondVal = double.Parse(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("Incorrect Value");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Enter the action");
                action = Console.ReadLine();

                if (action == "+")
                {
                    Console.WriteLine(firstVal + secondVal);
                }
                else if (action == "-")
                {
                    Console.WriteLine(firstVal - secondVal);
                }
                else if (action == "*")
                {
                    Console.WriteLine(firstVal * secondVal);
                }
                else if (action == "/")
                {
                    if (secondVal == 0)
                    {
                        Console.WriteLine("You can't divide on 0. Lol 67676767");
                    }
                    else
                    {
                        Console.WriteLine(firstVal / secondVal);
                    }
                }
                else
                {
                    Console.WriteLine("Error");
                }
                Console.ReadLine();
            }
        }
    }
}