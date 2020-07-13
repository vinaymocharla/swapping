using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("swapping of numbers");
            int num1, num2;
            Console.WriteLine("enter two numbers");
            num1 = Convert.ToInt16(Console.ReadLine());
            num2 = Convert.ToInt16(Console.ReadLine());
            num2 = num1 + num2;
            num1 = num2 - num1;
            num2 = num2 - num1;
            Console.WriteLine($"After swapping num1={ num1} and num2= { num2 }");
            Console.ReadLine();
        }
            
    }
}
