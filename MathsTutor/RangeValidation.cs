using System;
namespace MathsTutor
{
	//abstract class to reinforce the fact abstration is used in the program
	public abstract class RangeValidation 
	{
		public RangeValidation()
		{
		}
		public abstract bool ValidateRange(int value, int lowerBoundary, int upperBoundary);
        public abstract bool ValidateRange(double value, double lowerBoundary, double upperBoundary);

    }
}

