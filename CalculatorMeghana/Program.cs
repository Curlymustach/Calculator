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

            string test = "hi";
            test.Split(' ','+');

            Console.WriteLine("CALCULATOR");
            Console.WriteLine("Instrutions:\n 1. Enter number, operation \n 2. Keep spaces in between numbers and operations 3. click enter when done with operation");

            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');

            for (int i = 0; i < inputs.Length; i+=2)
            {
                numbers.Push(int.Parse(inputs[i]));
            }
            for (int i = 1; i< inputs.Length; i+=2)
            {
                operations.Push(inputs[i]);
            }

            Console.WriteLine();
            numbers.Print();



            int first;
            string operation;
            int second;
            int solution;
            
            second = numbers.Pop();
            operation = operations.Pop();
            first = numbers.Pop();

            if (operation.Equals("*"))
            {
                solution = first * second;
                Console.WriteLine("{0}", solution);
            }
            else if (operation.Equals("/"))
            {
                solution = first / second;
                Console.WriteLine("{0}", solution);
            }
            else if (operation.Equals("+"))
            {
                solution = first + second;
                Console.WriteLine("{0}", solution);
            }
            else if (operation.Equals("-"))
            {
                solution = first - second;
                Console.WriteLine("{0}", solution);
            }








            Console.ReadKey();
        }
    }
}
