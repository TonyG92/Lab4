using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!: ");
            
            string response = "y";
            
            while(response == "y")
            {
                int num1 = Methods.GetInt("\nEnter an integer: ");
                Console.WriteLine("Number\tSquared\tCubed");
                Console.WriteLine("======\t======\t======");

                for (int i = 1; i <= num1; i++)
                {
                    Console.WriteLine($"{i} \t {i * i} \t {i * i * i}");
                }

                Console.WriteLine("\nContinue? (y/n): ");
                response = Console.ReadLine();
            }
           



        }
    }
}
