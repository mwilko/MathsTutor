using System;
namespace MathsTutor
{
	public class Input : RangeValidation // derived class Input inherits from base abstract class RangeValidation
	{
		public Input()
		{
		}
        //property used for error message
        //encapsulated TypeError property
        private string TypeError { get; } = "TypeError. Plase enter a valid value";

        //ad-hoc polymorphism (method overloading) included when overloading ValidateRange methods
        //int method is for choosing what the user wants the program to do, float method is
        //for entering their answer for the result of the cards
        public int GetInputAndTypeValidate(int intChoice)
        {
            bool isValid = false;
            do
            {
                isValid = int.TryParse(Console.ReadLine(), out intChoice);
                if (!isValid)
                {
                    Console.WriteLine(TypeError);
                }
            } while (!isValid);
            return intChoice;
        }

        public double GetInputAndTypeValidate(double doubleChoice)
        {
            bool isValid = false;
            do
            {
                isValid = double.TryParse(Console.ReadLine(), out doubleChoice);
                if (!isValid)
                {
                    Console.WriteLine(TypeError);
                }
            } while (!isValid);
            return doubleChoice;
        }

        //method to validate range of integer between a lower and upper boundary of integers
        //returns boolean value

        //ad-hoc polymorphism (method overloading) included when overloading ValidateRange methods
        //int method is for choosing what the user wants the program to do, float method is
        //for entering their answer for the result of the cards

        //sub-type polymorphism (method overriding) included when Validate Range overrides the base
        //abstract method from the RangeValidation abstract class
        public override bool ValidateRange(int value, int lowerBoundary, int upperBoundary)
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

        public override bool ValidateRange(double value, double lowerBoundary, double upperBoundary)
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

