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
            int counter = 0;
                     
                Console.Write("[" + counter + "]"):
            string userMathProblem = Console.ReadLine();
            Expression userExpression = new Expression();
            userExpression.verifyUserMathProblem(userMathProblem);

            Console.WriteLine(userExpression.mathFactorA);

            Console.WriteLine(userExpression.mathOperator);

            if(userExpression.mathOperator == "+") // call to method goes here instead of "+"
            {
                Console.WriteLine("add method");
            }
            else if (userExpression.mathOperator == "-")
            {
                Console.WriteLine("subtract method");
            }
            else if (userExpression.mathOperator == "*")
            {
                Console.WriteLine("multiply method");
            }
            else if (userExpression.mathOperator == "/")
            {
                Console.WriteLine("divide method");
            }
            else if (userExpression.mathOperator == "%")
            {
                Console.WriteLine("modulus method");
            }
            else
            {
                Console.WriteLine("please select a valid operator");
            }


            Console.WriteLine(userExpression.mathFactorB);

            Console.ReadLine();
           
        }

    }
}
