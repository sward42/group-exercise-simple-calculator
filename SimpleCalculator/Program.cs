using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading;


namespace SimpleCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE SIMPLE CALCULATOR! Type \"exit\" or \"quit\" to close at any time.");
            int counter = 1;
            bool userDoingMath = true;
            Constant constants = new Constant();
            MathProblemStack mathProblems = new MathProblemStack();
            while (userDoingMath)
            {
                Console.Write("[" + counter + "]  ");
                string userMathProblem = Console.ReadLine();
                if (userMathProblem.ToLower() == "quit" || userMathProblem.ToLower() == "exit")
                {
                
                    userDoingMath = false;
                    do
                    {
                        Console.WriteLine("Bye!");
                        Console.WriteLine("exiting in: ");
                        Thread.Sleep(1000);
                        Console.Write("3.. ");
                        Thread.Sleep(1000);
                        Console.Write("2.. ");
                        Thread.Sleep(1000);
                        Console.Write("1");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
    
                    } while (userDoingMath);
                    
                }
                else if (userMathProblem == "last")
                {
                    userMathProblem =  mathProblems.getLastMathProblem();
                }
                else if (userMathProblem == "lastq")
                {
                    Console.WriteLine("   = " + mathProblems.getLastMathProblem());
                }
                else if (userMathProblem.Contains("="))
                {
                    constants.verifyConstant(userMathProblem);
                }
                else if (userMathProblem.Any(x => char.IsLetter(x)) && userMathProblem.Length == 1)
                {
                    constants.getConstant(userMathProblem);
                }
                else if (userMathProblem.Any(x => char.IsLetter(x)) && !userMathProblem.Contains("=") && userMathProblem.Length > 1)
                {
                    userMathProblem = constants.updateMathProblemWithConstants(userMathProblem);
                }
                Expression userExpression = new Expression();
                userExpression.verifyUserMathProblem(userMathProblem);
                int mathFactorA = userExpression.mathFactorA;
                int mathFactorB = userExpression.mathFactorB;
                string operationUsed = userExpression.mathOperator;

                if (mathFactorA != 0 && operationUsed != null && mathFactorB != 0)
                {
                    mathProblems.addNewMathProblem((mathFactorA + operationUsed + mathFactorB).ToString());
                }
                switch (operationUsed)
                {
                    case "+":
                        Addition addNumbers = new Addition();
                        Console.WriteLine("   = " + addNumbers.AddNumbers(mathFactorA, mathFactorB));
                        break;

                    case "-":
                        Subtraction subtractNumbers = new Subtraction();
                        Console.WriteLine("   = " + subtractNumbers.SubtractNumbers(mathFactorA, mathFactorB));
                        break;

                    case "*":
                        Multiplication multiplyNumbers = new Multiplication();
                        Console.WriteLine("   = " + multiplyNumbers.MultiplyNumbers(mathFactorA, mathFactorB));
                        break;

                    case "/":
                        Division divideNumbers = new Division();
                        Console.WriteLine("   = " + divideNumbers.DivideNumbers(mathFactorA, mathFactorB));
                        break;

                    case "%":
                        Modulus modulusNumbers = new Modulus();
                        Console.WriteLine("   = " + modulusNumbers.ModulusNumbers(mathFactorA, mathFactorB));
                        break;

                    default:
                        break;
                }
                Console.WriteLine(Environment.NewLine);
                counter++;

            }

        }

    }
}
