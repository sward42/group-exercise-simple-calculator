using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace SimpleCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> mathProblems = new List<string>();


            int counter = 0;
            bool userDoingMath = true;
            while (userDoingMath)
            {
                counter++; 
                Console.Write("[" + counter + "]");
                string userMathProblem = Console.ReadLine();
                if (userMathProblem == "quit" || userMathProblem == "exit")
                {
                    userDoingMath = false;
                    Environment.Exit(0);
                }
                else if (userMathProblem == "last")
                {
                    for (int i = 0; i < mathProblems.Count; i++)
                    {
                        userMathProblem = mathProblems[i];
                    }
                }
                Expression userExpression = new Expression();
                    userExpression.verifyUserMathProblem(userMathProblem);
                int mathFactorA = userExpression.mathFactorA;
                int mathFactorB = userExpression.mathFactorB;
                string operationUsed = userExpression.mathOperator;

                mathProblems.Add(mathFactorA + operationUsed + mathFactorB);

                    switch (operationUsed)
                    {
                        case "+":
                        Addition addNumbers = new Addition();
                        Console.WriteLine(addNumbers.AddNumbers(mathFactorA, mathFactorB));
                            break;

                        case "-":
                        Subtraction subtractNumbers = new Subtraction();
                        Console.WriteLine(subtractNumbers.SubtractNumbers(mathFactorA, mathFactorB));
                        break;

                        case "*":
                            Multiplication multiplyNumbers = new Multiplication();
                            Console.WriteLine(multiplyNumbers.MultiplyNumbers(mathFactorA, mathFactorB));
                            break;

                        case "/":
                            Division divideNumbers = new Division();
                            Console.WriteLine(divideNumbers.DivideNumbers(mathFactorA, mathFactorB));
                            break;

                    case "%":
                            //Console.WriteLine(description + operationUsed);
                            break;

                        default:
                            Console.WriteLine("Please select a valid operation");
                            break;
                    }

                    Console.WriteLine("Type enter to continue. Type exit or quit to leave the program");
                    Console.ReadLine();
                
            }

        }

    }
}
