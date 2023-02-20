using System;
namespace CMP1903M_A01_2223
{
	public class RangeValidation
	{
		public RangeValidation()
		{
		}

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
                Console.WriteLine(isValid);
            }
            return isValid;
        }
    }
}

