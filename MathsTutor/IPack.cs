using System;
namespace MathsTutor
{
	//abstraction achieved with the interface as it abstracts the important parts
	//of the class and ensure doesnt let the program run unless the class has these methods
	public interface IPack
	{
        //code needed for Pack Class to work (Skeleton code)
        public bool ShuffleCardPack();
		public void DealCard3();
        public void DealCard5();
		//OutputPack included for testing reasons
		public void OutputPack();
    }
}

