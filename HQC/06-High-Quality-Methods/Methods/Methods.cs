using System;

namespace Methods
{
    class Methods
    {
        /// <summary>
        /// Calculate triangle's area by given three sides.
        /// </summary>
        /// <param name="a">Side A</param>
        /// <param name="b">Side B</param>
        /// <param name="c">Side C</param>
        /// <returns>The area of the triangle.</returns>
        static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("The sides should be positive.");
            }

            if (!IsValidTriangle(a, b, c))
            {
                throw new ArgumentException("The given sides cannot form a valid triangle.");
            }

            double halfPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(halfPerimeter *
                (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            return area;
        }

        /// <summary>
        /// Validates if three sides can form a triangle.
        /// </summary>
        /// <param name="sideA">Side A</param>
        /// <param name="sideB">Side B</param>
        /// <param name="sideC">Side C</param>
        /// <returns>Result of the check.</returns>
        private static bool IsValidTriangle(double sideA, double sideB, double sideC)
        {
            return (sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA);
        }

        /// <summary>
        /// Gets the name of the given digit.
        /// </summary>
        /// <param name="digit">Digit you want to get the name of.</param>
        /// <returns>The name of the digit.</returns>
        static string GetDigitName(int digit)
        {
            switch (digit)
            {
                case 0: 
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    throw new ArgumentOutOfRangeException("The number you provide must be between 0 and 9.");
            }
        }

        /// <summary>
        /// Finds the maximal number.
        /// </summary>
        /// <param name="numbers">Array of numbers.</param>
        /// <returns>The maximal number.</returns>
        static int FindMax(params int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException("You should enter an collection of elements.");
            }

            if (numbers.Length == 0)
            {
                throw new ArgumentException("The numbers paramether must contain at least 1 value.");
            }

            int maxElement = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maxElement)
                {
                    maxElement = numbers[i];
                }
            }

            return maxElement;
        }

        /// <summary>
        /// Formates the given number to string in a given format.
        /// </summary>
        /// <param name="number">Number you want to format.</param>
        /// <param name="format">Format to apply to the number.</param>
        /// <returns>Formated number as string</returns>
        static string FormatNumber(object number, string format)
        {
            if (number == null)
            {
                throw new ArgumentNullException("You must provide a number.");
            }

            string formatedNumberAsString = String.Empty;

            switch (format)
            {
                case "f":
                    formatedNumberAsString = string.Format("{0:f2}", number);
                    break;
                case "%":
                    formatedNumberAsString = string.Format("{0:p0}", number);
                    break;
                case "r":
                    formatedNumberAsString = string.Format("{0,8}", number);
                    break;
                default:
                    throw new ArgumentException("The given format is not supported: " + format);
            }

            return formatedNumberAsString;
        }

        /// <summary>
        /// Calculates the distance between given two points.
        /// </summary>
        /// <param name="x1">X position of the first point.</param>
        /// <param name="y1">Y position of the first point.</param>
        /// <param name="x2">X position of the second point.</param>
        /// <param name="y2">Y position of the second point.</param>
        /// <returns>The distance between the points.</returns>
        static double CalculateDistanceBetweenPoints(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        /// <summary>
        /// Checks if a line between two given points is horizontal
        /// </summary>
        /// <param name="y1">Y position of the first point.</param>
        /// <param name="y2">Y position of the second point.</param>
        /// <returns>True if the line is horizontal, false if it is not.</returns>
        static bool CheckIfLineIsHorizontal(double y1, double y2)
        {
            bool horizontal = y1 == y2;
            return horizontal;
        }

        /// <summary>
        /// Checks if a line between two given points is vertical
        /// </summary>
        /// <param name="x1">X position of the first point.</param>
        /// <param name="x2">X position of the second point.</param>
        /// <returns>True if the line is vertical, false if it is not.</returns>
        static bool CheckIfLineIsVertical(double x1, double x2)
        {
            bool vertical = x1 == x2;
            return vertical;
        }

        static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));
            
            Console.WriteLine(GetDigitName(5));
            
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            Console.WriteLine(FormatNumber(1.3, "f"));
            Console.WriteLine(FormatNumber(0.75, "%"));
            Console.WriteLine(FormatNumber(2.30, "r"));

            double x1 = 3;
            double y1 = -1;
            double x2 = 3;
            double y2 = 2.5;
            bool horizontal = CheckIfLineIsHorizontal(y1, y2);
            bool vertical = CheckIfLineIsVertical(x1, x2);

            Console.WriteLine(CalculateDistanceBetweenPoints(x1, y1, x2, y2));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student("Peter", "Ivanov", new DateTime(1992, 03, 17), "Sofia");
            //peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student("Stella", "Markova", new DateTime(1993, 11, 03), "Vidin");
            //stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
