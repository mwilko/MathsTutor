using System;
namespace MathsTutor
{
	public class Input : RangeValidation // derived class Input inherits from base class RangeValidation
	{
		public Input()
		{
		}
        //property used for error message
        //encapsulated TypeError property
        protected string TypeError { get; } = "TypeError. Plase enter a valid value";

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
    }
}

