using System;
using System.Collections.Generic;

class CalculatingMathExpression
{

    static bool isLeftAssociative(string operatorToTest)
    {
        bool result = true;

        string[] rightAssociativeList =
        {
            "="
        };

        for (int i = 0; i < rightAssociativeList.Length; i++)
        {
            if (operatorToTest == rightAssociativeList[i])
            {
                result = false;
            }
        }

        return result;
    }

    static bool isFunction(string operation)
    {
        bool result = false;

        string[] functions =
        {
            "ln",
            "sqrt",
            "pow"
        };

        for (int i = 0; i < functions.Length; i++)
        {
            if (operation == functions[i])
            {
                result = true;
            }
        }

        return result;
    }

    static int CheckIfLessPrecedence(string operator1, string operator2)
    {
        int result = -1;
        int operator1Index = -1;
        int operator2Index = -1;

        string[] operators =
        {
            "-",
            "+",
            "*",
            "/",
            "("
        };

        int[] precedence =
        {
            1,
            1,
            2,
            2,
            3
        };

        for (int i = 0; i < operators.Length; i++)
        {
            if (operator1 == operators[i])
            {
                operator1Index = i;
            }
            if (operator2 == operators[i])
            {
                operator2Index = i;
            }
        }

        if (precedence[operator1Index] < precedence[operator2Index])
        {
            result = 1;
        }
        else if (precedence[operator1Index] > precedence[operator2Index])
        {
            result = 2;
        }
        else
        {
            result = 0;
        }

        return result;
    }

    static void ShuttingYard(string expression)
    {
        expression = expression.ToLower();
        string rpn = string.Empty;
        Queue<string> operands = new Queue<string>();
        Stack<string> operators = new Stack<string>();

        for (int i = 0; i < expression.Length; i++)
        {
            int testToken;
            bool isNumber = int.TryParse(expression[i].ToString(), out testToken);
            if (isNumber == true)
            {
                operands.Enqueue(expression[i].ToString());
            }
            else
            {
                if (expression[i] == ')' || expression[i] == ',')
                {
                    while (operators.Peek() != "(")
                    {
                        string popedUpOperator = operators.Pop();
                        operands.Enqueue(popedUpOperator);
                    }
                    operators.Pop();

                    if (isFunction(operators.Peek()))
                    {
                        string popedUpFunction = operators.Pop();
                        operands.Enqueue(popedUpFunction);
                    }
                }
                else
                {
                    if (operators.Count > 0)
                    {

                        if ((CheckIfLessPrecedence(expression[i].ToString(), operators.Peek()) == 1) ||
                            (isLeftAssociative(expression[i].ToString()) && CheckIfLessPrecedence(expression[i].ToString(),
                            operators.Peek()) == 0))
                        {
                            string popedUpOperator = operators.Pop();
                            operands.Enqueue(popedUpOperator);
                            operators.Push(expression[i].ToString());
                        }
                        else
                        {
                            operators.Push(expression[i].ToString());
                        }
                    }
                    else
                    {
                        operators.Push(expression[i].ToString());
                    }
                }
            }
        }

        if (operators.Count > 0)
        {
            while (operators.Count > 0)
            {
                string popedUpOperator = operators.Pop();
                operands.Enqueue(popedUpOperator);
            }
        }

        //print result
        while (operands.Count > 0)
        {
            rpn += operands.Dequeue();
        }

        Console.WriteLine(rpn);
    }

    static void Main()
    {
        Console.WriteLine("Enter expression:");
        string mathExpression = Console.ReadLine().Trim();

        ShuttingYard(mathExpression);
    }
}