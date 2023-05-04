using System;

namespace ProgrammingAssignment1
{
    // Don't change ANY of the code in this file; if you
    // do, you'll break the automated grader!

    /// <summary>
    /// Programming Assignment 1
    /// </summary>
    class Program
    {
        // test case to run
        static int testCaseNumber;

        /// <summary>
        /// Tests the Egg class
        /// </summary>
        /// <param name="args">command-line args</param>

        static void Main(string[] args)
        {
            Egg egg;

            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {
                // extract test case number from string
                GetInputValueFromString(input);

                // execute selected test case
                switch (testCaseNumber)
                {
                    case 1:
                        egg = new Egg(10, EggColor.Blue);
                        if (egg.Color == EggColor.Blue &&
                            egg.AmountLeft == 10)
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 2:
                        egg = new Egg(10, EggColor.White);
                        egg.Cook(HowCooked.Fried);
                        if (egg.CookedStatus == HowCooked.Fried)
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 3:
                        egg = new Egg(10, EggColor.White);
                        egg.Cook(HowCooked.Fried);
                        egg.Cook(HowCooked.HardBoiled);     // make sure no re-cooking
                        if (egg.CookedStatus == HowCooked.Fried)
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 4:
                        egg = new Egg(10, EggColor.White);
                        egg.Cook(HowCooked.Fried);
                        if (egg.IsCooked)
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 5:
                        egg = new Egg(10, EggColor.White);
                        egg.TakeBite(1);     // no effect because egg isn't cooked
                        if (egg.AmountLeft == 10)
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 6:
                        egg = new Egg(10, EggColor.White);
                        egg.Cook(HowCooked.HardBoiled);
                        egg.TakeBite(1);
                        if (egg.AmountLeft == 9)
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 7:
                        egg = new Egg(10, EggColor.White);
                        egg.Cook(HowCooked.HardBoiled);
                        egg.TakeBite(11);     // making sure amount left clamps at 0
                        if (egg.AmountLeft == 0)
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 8:
                        egg = new Egg(10, EggColor.White);
                        egg.Dye(EggColor.Blue);
                        if (egg.Color == EggColor.Blue)
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 9:
                        egg = new Egg(10, EggColor.Brown);
                        egg.Dye(EggColor.Blue);     // can only dye white eggs
                        if (egg.Color == EggColor.Brown)
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 10:
                        egg = new Egg(10, EggColor.White);
                        egg.Dye(EggColor.Brown);     // can only dye eggs blue
                        if (egg.Color == EggColor.White)
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                }

                input = Console.ReadLine();
            }
        }

        /// <summary>
        /// Extracts the test case number from the given input string
        /// </summary>
        /// <param name="input">input string</param>
        static void GetInputValueFromString(string input)
        {
            testCaseNumber = int.Parse(input);
        }
    }
}
