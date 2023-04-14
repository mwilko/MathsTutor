using System;
namespace MathsTutor
{
	public interface ICard
	{
		public int Value { get; set; }
        public int Suit { get; set; }
        public string SuitMessage { get; set; }

        public string ToString();
    }
}

