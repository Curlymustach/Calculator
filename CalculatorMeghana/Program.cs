using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMeghana
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            Stack<string> operations = new Stack<string>();

            Console.WriteLine("CALCULATOR");
            Console.WriteLine("Instrutions:\n 1. Enter operation(s)\n 2. \n");

            numbers.Push(int.Parse(Console.ReadLine()));

            operations.Push(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
