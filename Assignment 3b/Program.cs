using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number to find whether it is +ve//-ve//even//odd");
            int Number = int.Parse(Console.ReadLine());
            if (Number > 0)
            {
                Console.WriteLine("Number is +ve \t" + Number);
                if (Number % 2 == 0)
                {
                    Console.WriteLine("Even Number \t" + Number);
                }
                else
                {
                    Console.WriteLine("Odd Number \t" + Number);
                }
            }
            else
            {
                Console.WriteLine("Number is -ve \t" + Number);
                if (Number % 2 == 0)
                {
                    Console.WriteLine("Even Number \t" + Number);
                }
                else
                {
                    Console.WriteLine("Odd Number \t" + Number);
                }
            }
            Console.ReadKey();
        }
    }
}
