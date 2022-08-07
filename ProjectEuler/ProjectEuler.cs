using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectEuler
{
    /// <summary>
    /// Main static class for running project euler problems
    /// </summary>
    public static partial class ProjectEuler
    {
        private static readonly Dictionary<int, Func<long>> Problems = new()
        {
            { 7, Problem7 },
            { 8, Problem8 },
        };

        /// <summary>
        /// Answer dictionary, used for testing
        /// </summary>
        public static readonly Dictionary<int, long> Answers = new()
        {
            { 7, 104743 },
            { 8, 23514624000 },
        };

        /// <summary>
        /// Calculates the answer of the selected problem
        /// </summary>
        /// <param name="problemNumber"> Project Euler problem number </param>
        /// <returns></returns>
        public static long CalculateAnswer(int problemNumber)
        {
            if (!Problems.ContainsKey(problemNumber))
            {
                Console.WriteLine("Problem " + problemNumber.ToString() + " is not implemented");
                return -1;
            }

            return Problems[problemNumber]();
        }

        private static void PrintAnswer(int problemNumber, long answer)
        {
            Console.WriteLine("Problem #" + problemNumber);
            Console.WriteLine("\tAnswer = " + answer);
        }

        /// <summary>
        /// Pretty prints the answer and run time
        /// </summary>
        /// <param name="problemNumber"> Project Euler problem number </param>
        /// <param name="answer"></param>
        /// <param name="time"> time in ms </param>
        private static void PrintAnswer(int problemNumber, long answer, long time)
        {
            Console.WriteLine("Problem #" + problemNumber);
            Console.WriteLine("\tAnswer = " + answer);
            Console.WriteLine("\tRun Time = " + time + "ms");
        }

        /// <summary>
        /// Pretty prints the answer and run time
        /// </summary>
        /// <param name="problemNumber"> Project Euler problem number </param>
        /// <param name="answer"></param>
        /// <param name="time"> time in ms </param>
        private static void PrintAnswer(int problemNumber, double answer, long time)
        {
            Console.WriteLine("Problem #" + problemNumber);
            Console.WriteLine("\tAnswer = " + answer);
            Console.WriteLine("\tRun Time = " + time + "ms");
        }
    }
}