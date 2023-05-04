using System;
using UnityEngine;

namespace ProgrammingAssignment3
{
    /// <summary>
    /// Programming Assignment 3
    /// </summary>
    class Program
    {
        // unchanged constants from Mover
        const float MoveAmountPerSecond = 5;
        const float TimerDuration = 1;

        // test case to run
        static int testCaseNumber;

        // create mover
        static Vector3 initialPosition = new Vector3(-2.5f, 0, 0);
        static GameObject moverGameObject;
        static Mover mover;

        /// <summary>
        /// Programming Assignment 3
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // 60 fps built into UnityEngine mock Time object
            const int FPS = 60;

            // calculate move amount per frame
            float moveAmountPerFrame = MoveAmountPerSecond / FPS;

            // calculate iterations between direction changes
            int directionIterations = (int)(TimerDuration / Time.deltaTime);

            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {
                // extract test case number from string
                GetInputValueFromString(input);

                // execute selected test case
                InitializeTestCase();
                Timer directionTimer = mover.DirectionTimer;
                switch (testCaseNumber)
                {
                    case 1:
                        // game object hasn't moved yet
                        if (WithinOneHundredth(mover.Position.x, 
                            initialPosition.x))
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 2:
                        // game object moved right for one frame
                        UpdateTimerAndMover(directionTimer, mover);
                        if (WithinOneHundredth(mover.Position.x,
                            initialPosition.x + moveAmountPerFrame))
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 3:
                        // game object moved right for direction iterations frames
                        for (int i = 0; i < directionIterations; i++)
                        {
                            UpdateTimerAndMover(directionTimer, mover);
                        }
                        if (WithinOneHundredth(mover.Position.x,
                            initialPosition.x + directionIterations * moveAmountPerFrame))
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 4:
                        // game object moved left for one frame
                        // need to go 2 past direction iterations because of rounding
                        // 1 past has a tiny amount left on the timer so it's not finished yet
                        for (int i = 0; i < directionIterations + 2; i++)
                        {
                            UpdateTimerAndMover(directionTimer, mover);
                        }
                        if (WithinOneHundredth(mover.Position.x,
                            initialPosition.x + MoveAmountPerSecond -
                            moveAmountPerFrame))
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 5:
                        // game object moved left for direction iterations frames
                        // need 2 extra iterations because of rounding
                        // 1 extra iteration a tiny amount left on the timer so it's not finished yet
                        for (int i = 0; i < 2 * directionIterations + 2; i++)
                        {
                            UpdateTimerAndMover(directionTimer, mover);
                        }
                        if (WithinOneHundredth(mover.Position.x,
                            initialPosition.x))
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 6:
                        // game object moved right again for one frame
                        for (int i = 0; i < 2 * directionIterations + 1; i++)
                        {
                            UpdateTimerAndMover(directionTimer, mover);
                        }
                        if (WithinOneHundredth(mover.Position.x,
                            initialPosition.x + moveAmountPerFrame))
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 7:
                        // game object moved right again for direction iterations frames
                        // note accumulation of rounding error
                        for (int i = 0; i < 3 * directionIterations + 5; i++)
                        {
                            UpdateTimerAndMover(directionTimer, mover);
                        }
                        if (WithinOneHundredth(mover.Position.x,
                            initialPosition.x + MoveAmountPerSecond))
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 8:
                        // game object moved left again for one frame
                        // note accumulation of rounding error
                        for (int i = 0; i < 3 * directionIterations + 6; i++)
                        {
                            UpdateTimerAndMover(directionTimer, mover);
                        }
                        if (WithinOneHundredth(mover.Position.x,
                            initialPosition.x + MoveAmountPerSecond -
                            moveAmountPerFrame))
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 9:
                        // game object moved left again for direction iterations frames
                        // note accumulation of rounding error
                        for (int i = 0; i < 4 * directionIterations + 6; i++)
                        {
                            UpdateTimerAndMover(directionTimer, mover);
                        }
                        if (WithinOneHundredth(mover.Position.x,
                            initialPosition.x))
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 10:
                        // game object moved right again for one frame
                        // note accumulation of rounding error
                        for (int i = 0; i < 4 * directionIterations + 9; i++)
                        {
                            UpdateTimerAndMover(directionTimer, mover);
                        }
                        if (WithinOneHundredth(mover.Position.x,
                            initialPosition.x + moveAmountPerFrame))
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

        /// <summary>
        /// Checks if the given values are within 1/100 of each other
        /// </summary>
        /// <param name="firstValue">first value</param>
        /// <param name="secondValue">second value</param>
        /// <returns>true if the values are within 1/100, false otherwise</returns>
        static bool WithinOneHundredth(float firstValue, float secondValue)
        {
            return Math.Abs(firstValue - secondValue) <= 0.01f;
        }

        /// <summary>
        /// Initializes the test case by creating new objects and 
        /// calling Start
        /// </summary>
        static void InitializeTestCase()
        {
            mover = new Mover();
            moverGameObject = new GameObject(0,
                new Transform(initialPosition));
            mover.gameObject = moverGameObject;
            mover.Start();
        }

        /// <summary>
        /// Updates the timer and the mover
        /// </summary>
        /// <param name="timer">timer to update</param>
        /// <param name="mover">mover to update</param>
        static void UpdateTimerAndMover(Timer timer, Mover mover)
        {
            timer.Update();
            mover.Update();
            
        }
    }
}