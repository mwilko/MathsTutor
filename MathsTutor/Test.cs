using System;
namespace MathsTutor
{
	//used to verify if the maths is correct
	public class Test
	{
        public Test()
        {

        }
        Pack pack = new Pack();
        private string testStringAnswer = "13*12";
        private double answer = 13*12;

        public void MathsTest3Cards()
        {
            if (answer == pack.GetAnswer(testStringAnswer))
            {
                Console.WriteLine($"Equation:{testStringAnswer}		IDE calculation:{answer}	GetAnswerBODMAS method calculation:{pack.GetAnswer(testStringAnswer)}");
            }
            else
            {
                Console.WriteLine($"Answer is invalid: {answer}, {pack.GetAnswerBODMAS(testStringAnswer)}");
            }
        }

        private string testStringAnswer5Card = "3*5/2";
        //answer5Card was outputting as 7 when it was 7.5, this was fixed by setting variable to double
        //as well as changing data to decimals instead of full numbers
        private double answer5Card = 3.0 * 5.0 / 2.0;

        public void MathsTest5Cards()
		{
			if (answer5Card == pack.GetAnswerBODMAS(testStringAnswer5Card))
			{
				Console.WriteLine($"Equation:{testStringAnswer5Card}		IDE calculation:{answer5Card}	GetAnswerBODMAS method calculation:{pack.GetAnswerBODMAS(testStringAnswer5Card)}");
			}
            else
            {
                Console.WriteLine($"Answer is invalid: {answer5Card}, {pack.GetAnswerBODMAS(testStringAnswer5Card)}");
            }
		}
	}
}

