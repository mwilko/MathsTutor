using System;
namespace MathsTutor
{
	public interface ICard
	{
        //code needed for Card Class to work (Skeleton code)
		public int Value { get; set; }
        public int Suit { get; set; }
        public string SuitMessage { get; set; }

        public string ToString();
    }
}

