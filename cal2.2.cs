using System;

namespace Calculator202
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Calculator (2.2) [made by darsh]");
            Console.WriteLine("****************************");
            Console.WriteLine();
            char command; double Number;

            Console.WriteLine("enter the first number in the operation");

            Number = ask_for_number();

            Console.WriteLine("*** Choose the operation you want to perform by enter the symbol ***");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Available operations :");
            Console.WriteLine();
            do
            {
                menu1();
                command = ask_for_char();
                switch (command)
                {
                    case '!':
                        Number = factorial(Number);
                        break;
                    case '^':
                        Number = power(Number);
                        break;
                    case '+':
                        Number = opp(Number, command);
                        break;
                    case '-':
                        Number = opp(Number, command);
                        break;
                    case '*':
                        Number = opp(Number, command);
                        break;
                    case '/':
                        Number = opp(Number, command);
                        break;
                    case '%':
                        Number = opp(Number, command);
                        break;
                    case 'r':
                        Number = root(Number);
                        break;
                    case 'c':
                        Console.WriteLine("enter a new number");
                        Number = ask_for_number();
                        break;
                    case 'q':
                        break;
                    default:
                        Console.WriteLine("Error, please enter correct symbol");
                        continue;
                }
            } while (command != 'q');
            Console.WriteLine($"Total = {Number}");
            Console.WriteLine("good by ;)");

        }

        static void menu1()
        {
            Console.WriteLine("_________");
            Console.Write("|(!) factorial");
            Console.Write(" (r) root");
            Console.WriteLine(" (^) power|");
            Console.Write("|(+) addition");
            Console.Write(" (-) Subtract");
            Console.Write(" (*) multiply");
            Console.WriteLine(" (/) division|");
            Console.Write("|(c) clear");
            Console.WriteLine(" (q) quit|");
        }
        static double opp (double Number, char command)
        {
            double second_number;
            Console.WriteLine("enter the second number");
            second_number = ask_for_number();
            double tempnumber = Number;
            switch (command)
            {
                case '+':
                    Number += second_number;
                    break;
                case '-':
                    Number -= second_number;
                    break;
                case '*':
                    Number *= second_number;
                    break;
                case '/':
                    while (second_number == 0)
                    {
                        Console.WriteLine("You cannot divide by 0, please enter a new number");
                        second_number = ask_for_number();
                    }
                    Number /= second_number;
                    break;
                case '%':
                    Number %= second_number;
                    break;

            }
            Console.WriteLine($"{tempnumber} {command} {second_number} = {Number}");
            return Number;

        }
        static double factorial(double Number)
        {
         double result = 1;
        if (Number > 0)
        {
            for (int i = 1; i <= Number; i++)
            {
              result *= i;
            }
        }
        else
        {
            for (int i = -1; i >= Number; i--)
            {
                result *= i;
            }
        }
        Console.WriteLine($"{Number}!= {result}");
        Number = result;
        return Number;
            
        }
        static double power(double Number)
        {
            Console.WriteLine("Enter the Power number");
            double power = ask_for_number();
            double tempnumber = Number;
            switch (power)
            {
                case 0:
                    Number = 1;
                        break;
                default:
                    if (power < 0)
                    {
                        for (int count = -1; count > power; count--)
                            Number *= tempnumber;
                            Number = 1 / Number;
                    }
                    else 
                         for (int count = 1; count < power; count++)
                            Number *= tempnumber;
                    break;
            }
            Console.WriteLine($"{tempnumber}^{power} = {Number}");
            return Number;
        }
        static double root(double Number)
        {
            double tempnumber = Number;
            while(Number < 1)
            {
                Console.WriteLine("You cannot enter number less than 1, Please choose a new number");
                Number = ask_for_number();
            }
            Console.WriteLine(Math.Sqrt(Number));
            Console.WriteLine($"√{tempnumber} = {Number}");
            return Number;
        }

        static double ask_for_number()
        {
            double ask_number;
            do
            {
                try
                {
                    ask_number = double.Parse(Console.ReadLine());
                    return ask_number;
                }
                catch
                {
                    Console.WriteLine("Error, Please enter a real number");
                }
            } while (true);
        }
        static char ask_for_char()
        {
            char ask_char;
            do
            {
                try
                {
                    ask_char = char.Parse(Console.ReadLine());
                    return ask_char;
                }
                catch
                {
                    Console.WriteLine("Error, please enter correct symbol");
                }
            } while (true);
        }

        //static double addition(double n)
        //{
        //    Console.WriteLine("enter number to sum);
        //    double second_number;
        //    second_number = double.Parse(Console.ReadLine());
        //    n += second_number;
        //    Console.WriteLine($"addition = {n}");
        //    return n;
        //}
        //static double Subtract(double n)
        //{
        //    Console.WriteLine("enter number to Subtract");
        //    double second_number;
        //    second_number = double.Parse(Console.ReadLine());
        //    n -= second_number;
        //    Console.WriteLine($"Subtract = {n}");
        //    return n;
        //}
        //static double Multiply(double n)
        //{
        //    Console.WriteLine("enter number to Multiply");
        //    double second_number;
        //    second_number = double.Parse(Console.ReadLine());
        //    n *= second_number;
        //    Console.WriteLine($"Multiply = {n}");
        //    return n;
        //}

        //static double division(double n)
        //{
        //    Console.WriteLine("enter number to division");
        //    double second_number;
        //    second_number = double.Parse(Console.ReadLine());
        //    while (second_number == 0)
        //    {
        //        Console.WriteLine("Please enter a value other than 0");
        //        second_number = double.Parse(Console.ReadLine());
        //    }
        //    n /= second_number;
        //    Console.WriteLine($"division = {n}");
        //    return n;
        //}
    }
}
