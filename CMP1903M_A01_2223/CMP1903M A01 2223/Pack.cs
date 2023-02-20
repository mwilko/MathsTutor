using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Pack 
    {
        //list and objects initialised
        //limiting capacity of list to 52
        public List<Card> CardPack = new List<Card>(52);
        Input input = new Input();
        RangeValidation rangeValidation = new RangeValidation();
        Shuffling shuffling = new Shuffling();
        public Random random = new Random();

        public Pack()
        {
            //initialise the card pack here
            CreatePack();
        }

        public void CreatePack()
        {
            //for loop which continues till list is full. Values from 1-13
            for (int card = 0; card < 52; card++)
            {
                Card.Suits suit = (Card.Suits)(Math.Floor((decimal)card / 13));
                int value = card % 13 + 1;
                CardPack.Add(new Card(value, suit));
            }
        }

        public void OutputPack()
        {
            Console.WriteLine("\n");
            Console.WriteLine("----< Pack of Cards >----");
            //loops through list and displays each index value
            foreach (Card card in this.CardPack)
            {
                Console.WriteLine(card.Identity);
            }
            Console.WriteLine("\n");
        }

        public bool shuffleCardPack(int typeOfShuffle)
        {
            int FisherYates = 1;
            int RiffleShuffle = 2;
            int NoShuffle = 3;

            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == FisherYates)
            {
                int RandomValue(int from, int to) => random.Next(from, to);
                for (int s = 0; s < CardPack.Capacity - 1; s++)
                {
                    Console.WriteLine("hello world: fisheryates");
                    int GenObj = RandomValue(s, CardPack.Capacity);

                    var h = CardPack[s];
                    CardPack[s] = CardPack[GenObj];
                    CardPack[GenObj] = h;
                }
                return true;
            }
            else if (typeOfShuffle == RiffleShuffle)
            {
                return true;
            }
            else if (typeOfShuffle == NoShuffle)
            {
                return true;
            }
            else
            {
                Console.WriteLine($"Value: '{typeOfShuffle}' is not valid: ");
                return false;
            }

        }
        //public static Card deal()
        //{
        //    //Deals one card

        //}
        //public static List<Card> dealCard(int amount)
        //{
        //    //Deals the number of cards specified by 'amount'
        //}
    }
}
