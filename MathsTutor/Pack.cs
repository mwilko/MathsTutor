using System;
namespace MathsTutor
{
	public class Pack
	{
        //list and objects initialised
        public static List<Card> CardPack;
        public static List<Card> RifflePack = new List<Card>();
        public static bool shufflingBool = false;
        private Random random = new Random();

        public int[] suits = { 1, 2, 3, 4 };
        public int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

        public Pack()
        {
            //initialise the card pack here
            CardPack = new List<Card>();
            foreach (int suit in suits)
            {
                CardPack.Add(new Card(suit));
                foreach (int value in values)
                {
                    //when adding set method validation, realised the value and suit
                    //should be swapped since they were outputted opposite
                    CardPack.Add(new Card(value, "adding value"));
                }
            }
        }

        public bool shuffleCardPack()
        {
            //fisher-yates shuffling algorithm 
            int n = CardPack.Count;
            shufflingBool = true;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card card = CardPack[k];
                CardPack[k] = CardPack[n];
                CardPack[n] = card;
            }
            //OutputPack();
            return true;
        }
        public static Card dealCard()
        {
            //Deals one card
            //card object is set to null as if all bool variables are false
            //the card object would have no value for the method to return
            Card card = null;
            //loop to deal card out of fisher-yates shuffled card pack
            if (shufflingBool == true)
            {
                if (CardPack.Count == 0)
                {
                    Console.WriteLine("Error: Pack is empty");
                }
                card = CardPack[0];
                CardPack.RemoveAt(0);
            }
            else
            {
                //error message to catch any errors which may occur
                Console.WriteLine("Error: Unexpected error, contact IT support: ");
            }
            //card object marked as warning as it could be outputted as null/nothing
            return card;

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> hand = new List<Card>();

            for (int i = 0; i < amount; i++)
            {
                hand.Add(dealCard());
            }
            return hand;
        }

        //created for testing purposes
        public void OutputPack()
        {
            //displays card pack for fisher-yates shuffle
            Console.WriteLine("--------- <Pack> ---------");
            foreach (var card in CardPack)
            {
                Console.WriteLine(card);
            }
        }

    }
}

