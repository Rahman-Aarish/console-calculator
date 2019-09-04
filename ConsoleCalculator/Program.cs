using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2,result=0;
            string ops,choice;

            do
            {
                Console.WriteLine("Console Calculator App.");

                Console.Write("\nEnter first number : ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nSelect operator (+,-,*,/) : ");
                ops = Console.ReadLine();

                Console.Write("\nEnter second number : ");
                num2 = Convert.ToDouble(Console.ReadLine());

                if (ops == "+")
                {
                    result = num1 + num2;
                }
                else if (ops == "-")
                {
                    result = num1 - num2;
                }
                else if (ops == "*")
                {
                    result = num1 * num2;
                }
                else if (ops == "/")
                {
                    result = num1 / num2;
                    //Console.WriteLine("\n" + num1 + " / " + num2 + " = " + result);
                }
                else
                {
                    Console.WriteLine("\nInvalid Operator!");
                }

                if (ops == "+" || ops == "-" || ops == "*" || ops == "/")
                {
                    Console.WriteLine("\n"+result);
                }

                Console.Write("\nPress (Y) to continue or any other key to exit : ");
                choice = Console.ReadLine();

                Console.Clear();
            } while (choice=="Y"||choice=="y");
        }
    }
}
