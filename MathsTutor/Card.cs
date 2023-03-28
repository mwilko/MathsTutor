using System;
namespace MathsTutor
{
    public class Card
    { 
    private int _value;
    public int Value
    {
        get { return _value; }
        //added validation to set methods due to code review, forgot to include it
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
    private int _suit;
    public int Suit
    {
        get { return _suit; }
        //this ensures card suit only uses values 1-4
        set
        {
            if (value >= 1 && value <= 4)
            {
                _suit = value;
            }
            else
            {
                throw new Exception("Error, Suit value should be " +
                    "between 1 and 4.");
            }
        }
    }

    private string _suitMessage;
    public string SuitMessage
    {
        //added SuitMessage property to display the suit in string form after code review
        get { return _suitMessage; }
        set
        {
            if (value == "+")
            {
                _suitMessage = value;
            }
            else if (value == "-")
            {
                _suitMessage = value;

            }
            else if (value == "*")
            {
                _suitMessage = value;

            }
            else if (value == "/")
            {
                _suitMessage = value;
            }
            else
            {
                throw new Exception("Error, SuitMessage should be either:" +
                    " =, -, * or / ");
            }
        }
    }

    //ad-hoc polymorphism (method overloading) included when overloading Card constructors
    public Card(int value, string VerifyValue)
    {
        this.Value = value;
    }

    public Card(int suit)
    { 
        this.Suit = suit;
    }

    public override string ToString()
    {
        //the cards are in the form of an integer value and string value‹. 
        string suitValue = "";
        if (Suit == 1)
        {
            suitValue = "Hearts";
        }
        else if (Suit == 2)
        {
            suitValue = "Diamonds";
        }
        else if (Suit == 3)
        {
            suitValue = "Clubs";
        }
        else if (Suit == 4)
        {
            suitValue = "Spades";
        }
        return $"{Value} of {Suit} ({suitValue}) ";
    }
}
}

