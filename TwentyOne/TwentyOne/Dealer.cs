﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0);

            //Hand.Add(Deck.Cards.First());
            //string card = string.Format(Deck.Cards.First().ToString() + "\n");
            //Console.WriteLine(card);
            //using (StreamWriter file = new StreamWriter(@"C:\Users\Kurt\Desktop\Logs", true))
            //{
            //    file.WriteLine(card);
            //}
            //Deck.Cards.RemoveAt(0);
        }
    }
}
