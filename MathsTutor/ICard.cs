using System;
namespace MathsTutor
{
    //abstraction achieved with the interface as it abstracts the important parts
    //of the class and ensure doesnt let the program run unless the class has these methods and properties
    public interface ICard
	{
        //code needed for Card Class to work (Skeleton code)
		public int Value { get; set; }
        public int Suit { get; set; }
        public string SuitMessage { get; set; }

        public string ToString();
    }
}

