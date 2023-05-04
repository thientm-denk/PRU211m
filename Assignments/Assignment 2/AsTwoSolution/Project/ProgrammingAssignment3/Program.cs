using System;
using System.Collections.Generic;
using ConsoleCards;

namespace ProgrammingAssignment3
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided
    // makes your solution work with the 
    // automated grader on Coursera

    /// <summary>
    /// Programming Assignment 3
    /// </summary>
    class Program
    {
        /// <summary>
        /// Programming Assignment 3
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {
                // Create deck
                Deck deck = new Deck();

                // deal 2 cards each to 4 players (deal properly, dealing
                // the first card to each player before dealing the
                // second card to each player)
                List<Card> player1 = new List<Card>();
                List<Card> player2 = new List<Card>();
                List<Card> player3 = new List<Card>();
                List<Card> player4 = new List<Card>();

                player1.Add(deck.TakeTopCard());
                player2.Add(deck.TakeTopCard());
                player3.Add(deck.TakeTopCard());
                player4.Add(deck.TakeTopCard());
                player1.Add(deck.TakeTopCard());
                player2.Add(deck.TakeTopCard());
                player3.Add(deck.TakeTopCard());
                player4.Add(deck.TakeTopCard());
      
                // deal 1 more card to players 2 and 3
                player2.Add(deck.TakeTopCard());
                player3.Add(deck.TakeTopCard());

                // flip all the cards over
                foreach (var card in player1)
                {
                    card.FlipOver();
                }
                foreach (var card in player2)
                {
                    card.FlipOver();
                    
                }
                foreach (var card in player3)
                {
                    card.FlipOver();
                }
                foreach (var card in player4)
                {
                    card.FlipOver();
                }

                // print player 1
                // flip all the cards over
                foreach (var card in player1)
                {
                    Console.WriteLine(card.Rank + "," + card.Suit);
                }

                // print player 2
                foreach (var card in player2)
                {
                    Console.WriteLine(card.Rank + "," + card.Suit);
                }
    
                // print player 3
                foreach (var card in player3)
                {
                    Console.WriteLine(card.Rank + "," + card.Suit);
                }

                // print player 4
                foreach (var card in player4)
                {
                    Console.WriteLine(card.Rank + "," + card.Suit);
                }
                // Don't add or modify any code below
                // this comment
                input = Console.ReadLine();
            }
        }
    }
}