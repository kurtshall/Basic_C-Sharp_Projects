using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            
            for (int i = 0; i < 13; i++ )
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            
            for (int i = 0; i < times; i++)
            {
                
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomeIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomeIndex]);
                    Cards.RemoveAt(randomeIndex);
                }
                Cards = TempList;
            }
        }



        //public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        //{
        //    timesShuffled = 0;
        //    for (int i = 0; i < times; i++)
        //    {
        //        timesShuffled++;
        //        List<Card> TempList = new List<Card>();
        //        Random random = new Random();

        //        while (deck.Cards.Count > 0)
        //        {
        //            int randomeIndex = random.Next(0, deck.Cards.Count);
        //            TempList.Add(deck.Cards[randomeIndex]);
        //            deck.Cards.RemoveAt(randomeIndex);
        //        }
        //        deck.Cards = TempList;
        //    }

        //    return deck;

        //}


        //List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
        //List<string> Faces = new List<string>()
        //    {
        //        "Two", "Three", "Four" , "Five", "Six", "Seven", "Eight",
        //         "Nine", "Ten", "Jack", "Queen", "King", "Ace"
        //    };

        //    foreach (string face in Faces)
        //    {
        //        foreach (string suit in Suits)
        //        {
        //            Card card = new Card();
        //card.Suit = suit;
        //            card.Face = face;
        //            Cards.Add(card);
        //        }

    }
}
