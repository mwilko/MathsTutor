using System;
namespace MathsTutor
{
	public class RangeValidation 
	{
		public RangeValidation()
		{
		}
        //method to validate range of integer between a lower and upper boundary of integers
        //returns boolean value

        //ad-hoc polymorphism (method overloading) included when overloading ValidateRange methods
        //int method is for choosing what the user wants the program to do, float method is
        //for entering their answer for the result of the cards
        public bool ValidateRange(int value, int lowerBoundary, int upperBoundary)
        {
            bool isValid = false;
            if (value >= lowerBoundary && value <= upperBoundary)
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine($"The value {value} entered is outside the acceptable range.\n" +
                    $"The value must be between {lowerBoundary} and {upperBoundary}\n");
                Console.WriteLine($"Try again, enter your value: ");
                isValid = false;
            }
            return isValid;
        }

        public bool ValidateRange(double value, double lowerBoundary, double upperBoundary)
        {
            bool isValid = false;
            if (value >= lowerBoundary && value <= upperBoundary)
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine($"The value {value} entered is outside the acceptable range.\n" +
                    $"The value must be between {lowerBoundary} and {upperBoundary}\n");
                Console.WriteLine($"Try again, enter your value: ");
                isValid = false;
            }
            return isValid;
        }
    }
}

