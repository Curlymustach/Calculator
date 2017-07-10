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
            Console.WriteLine("Instrutions:\n 1. Enter number, operation \n 2. Keep spaces in between numbers and operations 3. click enter when done with operation");

            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');

            for (int i = 0; i < inputs.Length; i += 2)
            {
                numbers.Push(int.Parse(inputs[i]));
            }
            for (int i = 1; i < inputs.Length; i += 2)
            {
                operations.Push(inputs[i]);
            }

            Console.WriteLine();
            numbers.Print();
            Console.WriteLine();
            operations.Print();
            Console.WriteLine();


            int second = numbers.Pop();
            int first = numbers.Pop();
            string operation = operations.Pop();

            int solution = Calculate(first, operation, second);



            while (numbers.Count > 0 && operations.Count > 0)
            {
                first = numbers.Pop();
                operation = operations.Pop();
                second = solution;
                solution = Calculate(first, operation, second);

            }

            Console.WriteLine("{0}", solution);
            Console.ReadKey();
        }

        static int Calculate(int first, string operation, int second)
        {
            int solution = 0;


            if (operation.Equals("*"))
            {
                solution = first * second;

            }
            else if (operation.Equals("/"))
            {
                solution = first / second;

            }
            else if (operation.Equals("+"))
            {
                solution = first + second;

            }
            else if (operation.Equals("-"))
            {
                solution = first - second;

            }

            Console.WriteLine($"{solution} = {first} {operation} {second}");


            return solution;
        }
    }
}
