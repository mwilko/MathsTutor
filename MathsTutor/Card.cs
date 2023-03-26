using System;
namespace MathsTutor
{
	public class Card
	{
        private int _value;
        public int Value
        {
            get { return _value; }
            //this ensures card value only uses values 1-13
            set
            {
                if (value >= 1 && value <= 13)
                {
                    _value = value;
                }
                else
                {
                    throw new Exception("Error, Value should be " +
                        "between 1 and 13. ");
                }
            }
        }
        private string _suit;
        public string Suit
        {
            get { return _suit; }
            //this ensures card suit only uses values 1-4
            set
            {
                if (value == "+")
                {
                    _suit = value;
                }
                else if (value == "-")
                {
                    _suit = value;
                }
                else if (value == "/")
                {
                    _suit = value;
                }
                else if (value == "*")
                {
                    _suit = value;
                }
                else
                {
                    throw new Exception("Error: Suit values should be " +
                        "mathematical operators: +, -, / or *.");
                }
            }
        }

        //private string _suitMessage;
        //public string SuitMessage
        //{
        //    //added SuitMessage property to display the suit in string form after code review
        //    get { return _suitMessage; }
        //    set
        //    {
        //        if (value == "Hearts")
        //        {
        //            _suitMessage = value;
        //        }
        //        else if (value == "Diamonds")
        //        {
        //            _suitMessage = value;

        //        }
        //        else if (value == "Clubs")
        //        {
        //            _suitMessage = value;

        //        }
        //        else if (value == "Spades")
        //        {
        //            _suitMessage = value;
        //        }
        //        else
        //        {
        //            throw new Exception("Error, SuitMessage should be either:" +
        //                " Hearts, Diamonds, Clubs or Spades");
        //        }
        //    }
        //}

        public Card(int value, string suit)
        {
            this.Value = value;
            this.Suit = suit;
        }

        public override string ToString()
        {
            string suitValue = "";
            if (Suit == "+")
            {
                suitValue = "Addition";
            }
            else if (Suit == "-")
            {
                suitValue = "Subtraction";
            }
            else if (Suit == "/")
            {
                suitValue = "Division";
            }
            else if (Suit == "*")
            {
                suitValue = "Multiplication";
            }
            return $"{Value} of {Suit} ({suitValue}) ";
        }
    }
}

