/*
 * Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below: 
 * x2 + 5 = 1x2 + 0x + 5 -> 5 0 1
 */

using System;

class PolynomialOperations
{
    static void AddPolynomials(int[] poly1, int[] poly2)
    {
        int[] result = new int[Math.Max(poly1.Length, poly2.Length)];

        int[] longerPolynomial = poly1;
        int[] shorterPolynomial = poly2;

        if (poly1.Length < poly2.Length)
        {
            longerPolynomial = poly2;
            shorterPolynomial = poly1;
        }

        for (int i = 0; i < result.Length; i++)
        {
            if (i < shorterPolynomial.Length)
            {
                result[i] = shorterPolynomial[i] + longerPolynomial[i];
            }
            else
            {
                result[i] = longerPolynomial[i];
            }
        }

        PrintPolynomial(result);
    }

    static void SubstractPolynomials(int[] poly1, int[] poly2)
    {
        int[] result = new int[Math.Max(poly1.Length, poly2.Length)];

        int[] longerPolynomial = poly1;
        int[] shorterPolynomial = poly2;

        int secondPolynomNumber = 2;

        if (poly1.Length < poly2.Length)
        {
            longerPolynomial = poly2;
            shorterPolynomial = poly1;
            secondPolynomNumber = 1;
        }

        for (int i = 0; i < result.Length; i++)
        {
            if (i < shorterPolynomial.Length)
            {
                if (secondPolynomNumber == 1)
                {
                    result[i] = shorterPolynomial[i] + (-1 * longerPolynomial[i]);
                }
                else
                {
                    result[i] = longerPolynomial[i] + (-1 * shorterPolynomial[i]);
                }

            }
            else
            {
                result[i] = longerPolynomial[i];
            }
        }

        PrintPolynomial(result);
    }

    static void MultiplyPolynomials(int[] poly1, int[] poly2)
    {
        int[] result = new int[poly1.Length + poly2.Length - 1];

        for (int i = 0; i < poly1.Length; i++)
        {
            for (int j = 0; j < poly2.Length; j++)
            {
                result[i + j] += poly1[i] * poly2[j];
            }
        }

        PrintPolynomial(result);
    }

    static void PrintPolynomial(int[] polynomial)
    {
        for (int i = polynomial.Length - 1; i >= 0; i--)
        {
            if (polynomial[i] != 0)
            {
                if (polynomial[i] != 1)
                {
                    //Printing the signs
                    if (i < polynomial.Length - 1 && polynomial[i] > 0)
                    {
                        Console.Write(" + ");
                    }
                    else if (polynomial[i] < 0)
                    {
                        Console.Write(" ");
                    }

                    //Cases when we do not print the power or the coefficient
                    if (i == 0)
                    {
                        Console.Write("{0}", polynomial[i]);
                    }
                    else if (i == 1)
                    {
                        Console.Write("{0}x", polynomial[i]);
                    }
                    else
                    {
                        Console.Write("{0}x^{1}", polynomial[i], i);
                    }
                }
                else
                {
                    Console.Write("x^{0}", i);
                }
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] firstPolynomial = 
        {
            0,
            8,
            -2,
            6
        };

        int[] secondPolynomial =
        {
            10,
            -11,
            0,
            4
        };

        //Print the first polynomial
        PrintPolynomial(firstPolynomial);
        //Print the first polynomial
        PrintPolynomial(secondPolynomial);

        Console.WriteLine("Adding the two polynomials:");
        AddPolynomials(firstPolynomial, secondPolynomial);

        Console.WriteLine("Substracting the two polynomials:");
        SubstractPolynomials(firstPolynomial, secondPolynomial);

        Console.WriteLine("Multiplying of the two polynomials:");
        MultiplyPolynomials(firstPolynomial, secondPolynomial);
    }
}