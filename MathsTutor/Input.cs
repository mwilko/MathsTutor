using System;
namespace MathsTutor
{
	public class Input : RangeValidation
	{
		public Input()
		{
		}
        //property used for error message
        public string TypeError { get; } = "TypeError. Plase enter a valid value";

        //validation of choice input by user
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

