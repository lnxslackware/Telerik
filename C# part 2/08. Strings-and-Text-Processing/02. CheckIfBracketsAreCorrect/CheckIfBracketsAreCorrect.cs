/*
 * Write a program to check if in a given expression the brackets are put correctly.
 * Example of correct expression: ((a+b)/5-d).
 * Example of incorrect expression: )(a+b)).
 */

using System;

class CheckIfBracketsAreCorrect
{
    static void Main()
    {
        string expression = "((a+b)/5-d)";
        int openingBracketsCount = 0;
        int closingBracketsCount = 0;
        int lastfoundIndex = -1;

        //finding the count of the opening brackets
        while ((lastfoundIndex = expression.IndexOf('(', lastfoundIndex + 1)) > -1)
        {
            openingBracketsCount++;
        }

        lastfoundIndex = -1;

        //finding the count of the closing brackets
        while ((lastfoundIndex = expression.IndexOf(')', lastfoundIndex + 1)) > -1)
        {
            closingBracketsCount++;
        }

        //check if there are any brackets in the given expression
        bool bracketsExsistInExpression = openingBracketsCount > 0 && closingBracketsCount > 0;

        //if this variable is true the brackets are put corectly -> every opening bracket has closing bracket
        bool bracketsAreEqualCount = openingBracketsCount == closingBracketsCount;

        if (bracketsAreEqualCount && bracketsAreEqualCount)
        {
            Console.WriteLine("The brackets in the expression are puted correctly.");
        }
        else if (bracketsExsistInExpression == false)
        {
            Console.WriteLine("There are no brackets in the given expression.");
        }
        else
        {
            Console.WriteLine("The brackets in the expression are NOT puted correctly.");
        }
    }
}