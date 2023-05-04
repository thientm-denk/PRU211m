using System;
using System.Collections.Generic;
using ConsoleCards;

namespace ProgrammingAssignment3
{
    /// <summary>
    /// Programming Assignment 3
    /// </summary>
    class Program
    {
        // autograder support
        static int testCaseNumber = 0;
        static int nextCard = 0;
        static Card[] testCaseCards = new Card[9];

        static int numCards = 0;

        /// <summary>
        /// Programming Assignment 3
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // IMPORTANT: Only add code in the section
            // indicated below. The code I've provided
            // makes your solution work with the 
            // automated grader on Coursera
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {
                testCaseNumber = int.Parse(input);
                numCards = GetNumCards();
                InitializeTestCaseCards();
                nextCard = 0;

                // Add your code between this comment
                // and the comment below. You can of
                // course add more space between the
                // comments as needed

                // add cards to list
                List<Card> cardList = new List<Card>();
                for (int i = 0; i < numCards; i++)
                {
                    cardList.Add(GetCard());
                }

                // count numbers for card type
                int numClubs = 0;
                int numDiamonds = 0;
                int numHearts = 0;
                int numSpades = 0;
                foreach (Card card in cardList)
                {
                    card.FlipOver();
                    Suit suit = card.Suit;
                    switch (suit)
                    {
                        case Suit.Clubs:
                            numClubs++;
                            break;
                        case Suit.Diamonds:
                            numDiamonds++;
                            break;
                        case Suit.Hearts:
                            numHearts++;
                            break;
                        default:
                            numSpades++;
                            break;
                    }
                }

                // print counts
                Console.WriteLine("C" + numClubs + " " +
                                  "D" + numDiamonds + " " +
                                  "H" + numHearts + " " +
                                  "S" + numSpades);


                // Don't add or modify any code below
                // this comment
                input = Console.ReadLine();
            }
        }

        /// <summary>
        /// Gets a card
        /// <return>a card</return>
        /// </summary>
        static Card GetCard()
        {
            nextCard++;
            return testCaseCards[nextCard - 1];
        }

        /// <summary>
        /// Gets how many cards will be in the hand for the
        /// current test case number
        /// <return>number of cards to add to hand</return>
        /// </summary>
        static int GetNumCards()
        {
            switch (testCaseNumber)
            {
                case 1:
                case 2:
                case 6:
                    return 5;
                case 3:
                    return 2;
                case 4:
                    return 7;
                case 5:
                    return 0;
                case 7:
                    return 1;
                case 8:
                case 10:
                    return 4;
                case 9:
                    return 9;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Initializes the set of cards returned by GetCard based
        /// on the test case number
        /// </summary>
        static void InitializeTestCaseCards()
        {
            switch (testCaseNumber)
            {
                case 1:
                    testCaseCards[0] = new Card(Rank.Two, Suit.Clubs);
                    testCaseCards[1] = new Card(Rank.Three, Suit.Diamonds);
                    testCaseCards[2] = new Card(Rank.Four, Suit.Spades);
                    testCaseCards[3] = new Card(Rank.Ten, Suit.Spades);
                    testCaseCards[4] = new Card(Rank.Ace, Suit.Spades);
                    break;
                case 2:
                    testCaseCards[0] = new Card(Rank.Two, Suit.Clubs);
                    testCaseCards[1] = new Card(Rank.Three, Suit.Clubs);
                    testCaseCards[2] = new Card(Rank.Four, Suit.Clubs);
                    testCaseCards[3] = new Card(Rank.Ten, Suit.Clubs);
                    testCaseCards[4] = new Card(Rank.Ace, Suit.Clubs);
                    break;
                case 3:
                    testCaseCards[0] = new Card(Rank.Ten, Suit.Diamonds);
                    testCaseCards[1] = new Card(Rank.Ace, Suit.Diamonds);
                    break;
                case 4:
                    testCaseCards[0] = new Card(Rank.Two, Suit.Hearts);
                    testCaseCards[1] = new Card(Rank.Three, Suit.Hearts);
                    testCaseCards[2] = new Card(Rank.Four, Suit.Hearts);
                    testCaseCards[3] = new Card(Rank.Five, Suit.Hearts);
                    testCaseCards[4] = new Card(Rank.Six, Suit.Hearts);
                    testCaseCards[5] = new Card(Rank.Seven, Suit.Hearts);
                    testCaseCards[6] = new Card(Rank.Eight, Suit.Hearts);
                    break;
                case 6:
                    testCaseCards[0] = new Card(Rank.Ten, Suit.Clubs);
                    testCaseCards[1] = new Card(Rank.Jack, Suit.Clubs);
                    testCaseCards[2] = new Card(Rank.Queen, Suit.Clubs);
                    testCaseCards[3] = new Card(Rank.King, Suit.Clubs);
                    testCaseCards[4] = new Card(Rank.Ace, Suit.Clubs);
                    break;
                case 7:
                    testCaseCards[0] = new Card(Rank.Queen, Suit.Hearts);
                    break;
                case 8:
                    testCaseCards[0] = new Card(Rank.Jack, Suit.Clubs);
                    testCaseCards[1] = new Card(Rank.Jack, Suit.Diamonds);
                    testCaseCards[2] = new Card(Rank.Jack, Suit.Hearts);
                    testCaseCards[3] = new Card(Rank.Jack, Suit.Spades);
                    break;
                case 9:
                    testCaseCards[0] = new Card(Rank.Two, Suit.Spades);
                    testCaseCards[1] = new Card(Rank.Three, Suit.Spades);
                    testCaseCards[2] = new Card(Rank.Four, Suit.Spades);
                    testCaseCards[3] = new Card(Rank.Five, Suit.Spades);
                    testCaseCards[4] = new Card(Rank.Six, Suit.Spades);
                    testCaseCards[5] = new Card(Rank.Seven, Suit.Spades);
                    testCaseCards[6] = new Card(Rank.Eight, Suit.Spades);
                    testCaseCards[7] = new Card(Rank.Nine, Suit.Spades);
                    testCaseCards[8] = new Card(Rank.Ten, Suit.Spades);
                    break;
                case 10:
                    testCaseCards[0] = new Card(Rank.Two, Suit.Clubs);
                    testCaseCards[1] = new Card(Rank.Three, Suit.Diamonds);
                    testCaseCards[2] = new Card(Rank.Four, Suit.Hearts);
                    testCaseCards[3] = new Card(Rank.Five, Suit.Spades);
                    break;
                default:
                    break;
            }
        }
    }
}