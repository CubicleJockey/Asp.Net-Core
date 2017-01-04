using System;
using System.Numerics;
using static System.Console;
using System.Text;
using DemoConsole.Helpers;
using Utilities;

namespace DemoConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string userInput;
                do
                {
                    WriteLine(Menu());
                    userInput = ReadLine();
                    int option;
                    if (!int.TryParse(userInput, out option))
                    {
                        WriteLine(InvlaidOption());
                        continue;
                    }

                    switch (option)
                    {
                        case 1:
                            WriteLine(DoAddition());
                            WriteLine();
                            break;
                        case 2:
                            WriteLine(DoSubtraction());
                            WriteLine();
                            break;
                        case 3:
                            WriteLine(DoMultiplication());
                            WriteLine();
                            break;
                        case 4:
                            WriteLine(DoDivision());
                            WriteLine();
                            break;
                        default:
                            WriteLine(InvlaidOption());
                            WriteLine();
                            break;
                    }
                } while (userInput?.ToLower() != "q");
            }
            catch (Exception x)
            {
                WriteLine($"Error Occurred: {x.Message}");
                WriteLine("Shutting Down...");
            }
        }

        private static string Menu()
        {
            var sb = new StringBuilder();

            sb.AppendLine("------------------------------");
            sb.AppendLine("         Options              ");
            sb.AppendLine("------------------------------");
            sb.AppendLine("1: Addition");
            sb.AppendLine("2: Subtraction");
            sb.AppendLine("3: Multiplication");
            sb.AppendLine("4: Division");
            sb.AppendLine("Q/q: Quit");
            sb.AppendLine("------------------------------");
            sb.AppendLine("Enter Option: ");

            return sb.ToString();
        }

        private static string InvlaidOption()
        {
            return "Please select an option by a number. Valid options are 1 - 4";
        }

        private static string ErrorNotANumber()
        {
            return "Input was not a number.";
        }

        private static MathInput GetInputs()
        {
            WriteLine("Enter left hand value: ");
            var leftInput = ReadLine();
            long lhs;
            if (!long.TryParse(leftInput, out lhs))
            {
                WriteLine(ErrorNotANumber());
                return null;
            }

            WriteLine("Enter right hand value: ");
            var rightInput = ReadLine();
            long rhs;
            if (!long.TryParse(rightInput, out rhs))
            {
                WriteLine(ErrorNotANumber());
                return null;
            }
            return new MathInput(lhs, rhs);
        }

        private static string DoAddition()
        {
            WriteLine("Enter Numbers to add.");
            var inputs = GetInputs();

            if (inputs == null)
            {
                return null;
            }

            var result = Maths.Add(inputs.Lhs, inputs.Rhs);
            return $"Addition Result: {result}";
        }

        private static string DoSubtraction()
        {
            WriteLine("Enter Numbers to subtract.");
            var inputs = GetInputs();

            if (inputs == null)
            {
                return null;
            }

            var result = Maths.Subtract(inputs.Lhs, inputs.Rhs);
            return $"Subtraction Result: {result}";
        }

        private static string DoMultiplication()
        {
            WriteLine("Enter Numbers to multiply.");
            var inputs = GetInputs();

            if (inputs == null)
            {
                return null;
            }

            var result = Maths.Multiple(inputs.Lhs, inputs.Rhs);
            return $"Multiplication Result: {result}";
        }

        private static string DoDivision()
        {
            WriteLine("Enter Numbers to divide.");
            var inputs = GetInputs();

            if (inputs == null)
            {
                return null;
            }

            var result = Maths.Divide(inputs.Lhs, inputs.Rhs);
            return $"Division Result: {result}";
        }
    }
}
