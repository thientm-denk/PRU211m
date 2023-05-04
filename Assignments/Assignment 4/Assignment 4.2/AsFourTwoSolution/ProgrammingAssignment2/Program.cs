using System;

namespace ProgrammingAssignment2
{
    // Don't change ANY of the code in this file; if you
    // do, you'll break the automated grader!

    /// <summary>
    /// Programming Assignment 2
    /// </summary>
    class Program
    {
        // operation and arguments
        static int operation;
        static int firstArgument;
        static int secondArgument;

        /// <summary>
        /// Tests the Matherator class
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            Matherator matherator = new Matherator();

            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {
                // extract input values from string
                GetInputValuesFromString(input);

                // execute selected operation
                if (operation == 1)
                {
                    Console.WriteLine(matherator.GetNthEvenNumber(firstArgument) + " ");
                }
                else if (operation == 2)
                {
                    Console.WriteLine(matherator.GetTenthEvenNumber() + " ");
                }
                else if (operation == 3)
                {
                    matherator.PrintMToN(firstArgument, secondArgument);
                }
                else
                {
                    matherator.PrintOneToTen();
                }

                input = Console.ReadLine();
            }
        }

        /// <summary>
        /// Extracts the operation and arguments from the given input string
        /// </summary>
        /// <param name="input">input string</param>
        static void GetInputValuesFromString(string input)
        {
            // extract operation
            int spaceIndex = input.IndexOf(' ');
            operation = int.Parse(input.Substring(0, spaceIndex));

            // move along string and extract first argument
            input = input.Substring(spaceIndex + 1);
            spaceIndex = input.IndexOf(' ');
            firstArgument = int.Parse(input.Substring(0, spaceIndex));

            // second argument is the rest of the string
            input = input.Substring(spaceIndex + 1);
            secondArgument = int.Parse(input);
        }
    }
}
