using System;

namespace ProgrammingAssignment4
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided
    // makes your solution work with the 
    // automated grader on Coursera

    /// <summary>
    /// Programming Assignment 4
    /// </summary>
    class Program
    {
        /// <summary>
        /// Programming Assignment 4
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {
                // Add your code between this comment
                // and the comment below. You can of
                // course add more space between the
                // comments as needed

                // declare and initialize list
                int[] counts = new int[26];
                for (int i = 0; i < counts.Length; i++)
                {
                    counts[i] = 0;
                }

                // count the of each letter
                for (int i = 0; i < input.Length; i++)
                {
                    // only process alphabetic
                    if (char.IsLetter(input[i]))
                    {
                        // convert character to array index and increment count
                        char character = char.ToUpper(input[i]);
                        counts[ConvertCharToIndex(character)]++;
                    }
                }

                // print out input and non-zero character counts
                for (int i = 0; i < counts.Length; i++)
                {
                    if (counts[i] > 0)
                    {
                        //debugging
                        Console.Write(ConvertIndexToChar(i));
                        Console.Write(counts[i]);
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();

                // Don't add or modify any code below
                // this comment
                input = Console.ReadLine();
            }
        }

        /// <summary>
        /// Converts the given character to a 0-based index in an array
        /// of character counts. A is converted to 0, B is converted to 1,
        /// and so on
        /// NOTE: The provided character must be upper case 
        /// </summary>
        /// <param name="upperCaseCharacter">upper case character</param>
        /// <returns>0-based array index or -1 for invlid character</returns>
        static int ConvertCharToIndex(char upperCaseCharacter)
        {
            switch (upperCaseCharacter)
            {
                case 'A': return 0;
                case 'B': return 1;
                case 'C': return 2;
                case 'D': return 3;
                case 'E': return 4;
                case 'F': return 5;
                case 'G': return 6;
                case 'H': return 7;
                case 'I': return 8;
                case 'J': return 9;
                case 'K': return 10;
                case 'L': return 11;
                case 'M': return 12;
                case 'N': return 13;
                case 'O': return 14;
                case 'P': return 15;
                case 'Q': return 16;
                case 'R': return 17;
                case 'S': return 18;
                case 'T': return 19;
                case 'U': return 20;
                case 'V': return 21;
                case 'W': return 22;
                case 'X': return 23;
                case 'Y': return 24;
                case 'Z': return 25;
                default: return -1;
            }
        }

        /// <summary>
        /// Converts the given 0-based index in an array of character
        /// counts to the corresponding upper case character. 0 is converted 
        /// to A, 1 is converted to B, and so on
        /// Note the provided index must be between 0 and 25 inclusive
        /// </summary>
        /// <param name="index">0-based array index</param>
        /// <returns>upper case character or -1 for invalid index</returns>
        static char ConvertIndexToChar(int index)
        {
            switch (index)
            {
                case 0: return 'A';
                case 1: return 'B';
                case 2: return 'C';
                case 3: return 'D';
                case 4: return 'E';
                case 5: return 'F';
                case 6: return 'G';
                case 7: return 'H';
                case 8: return 'I';
                case 9: return 'J';
                case 10: return 'K';
                case 11: return 'L';
                case 12: return 'M';
                case 13: return 'N';
                case 14: return 'O';
                case 15: return 'P';
                case 16: return 'Q';
                case 17: return 'R';
                case 18: return 'S';
                case 19: return 'T';
                case 20: return 'U';
                case 21: return 'V';
                case 22: return 'W';
                case 23: return 'X';
                case 24: return 'Y';
                case 25: return 'Z';
                default: return '$';
            }
        }
    }
}