using System;
using CalculatorLibrary;

namespace CalculatorProgram
{
    class Calculator
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            Console.WriteLine("Welcome to this calculator!\r");
            Console.WriteLine("___________________________\n");

            CalculatorLibrary.Calculator calculator = new CalculatorLibrary.Calculator();
            while (!endApp)
            {
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                Console.WriteLine("Enter your first number: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.WriteLine("This is not valid input. Please enter and integer value: ");
                    numInput1 = Console.ReadLine();
                }

                Console.WriteLine("Type another number: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.WriteLine("This is not valid input. Please enter and integer value: ");
                    numInput2 = Console.ReadLine();
                }

                Console.WriteLine("Choose an operator from the list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                string op = Console.ReadLine();

                try
                {
                    result = calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occured trying to do the math\n - Details: " + e.Message);
                }
                Console.WriteLine("___________________\n");

                Console.Write("Press N and enter to close the app, or press any other key and enter to continue:");
                if (Console.ReadLine() == "N") endApp = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }
}