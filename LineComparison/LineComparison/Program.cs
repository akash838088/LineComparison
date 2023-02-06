using System;

namespace LineComparesion
{
    public class Program
    {
        static void Main(string[] args)
        {
            CalculateLength LengthOne = new CalculateLength(1, 2, 3, 4);
            double length1 = LengthOne.Calculate();

            CalculateLength LengthTwo = new CalculateLength(1, 2, 3, 4);
            double length2 = LengthTwo.Calculate();

            //UC2
            if (length1.Equals(length2))
            {
                Console.WriteLine("Both line are equal");
            }
            else
            {
                Console.WriteLine("Both lines are not equal");
            }

            //UC3
            if (length2.CompareTo(length2) == 0)
            {
                Console.WriteLine("Equal");
            }
            else if (length1.CompareTo(length2) > 0)
            {
                Console.WriteLine("Line one is grreter");
            }
            else
            {
                Console.WriteLine("Line two is greter");
            }
            Console.ReadLine();

        }
    }
}