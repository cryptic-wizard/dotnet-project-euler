using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    /// <summary>
    /// Main static class for running project euler problems
    /// </summary>
    public static partial class ProjectEuler
    {
        private static readonly Dictionary<int, Func<long>> Problems = new()
        {
            { 1,  Problem001 },
            { 2,  Problem002 },
            { 3,  Problem003 },
            { 4,  Problem004 },
            { 5,  Problem005 },
            { 6,  Problem006 },
            { 7,  Problem007 },
            { 8,  Problem008 },
            { 9,  Problem009 },
            { 10, Problem010 },
            { 11, Problem011 },
            { 12, Problem012 },
            { 13, Problem013 },
            { 14, Problem014 },
            { 15, Problem015 },
            { 16, Problem016 },
            { 17, Problem017 },
            { 19, Problem019 },
            { 20, Problem020 },
            { 21, Problem021 },
            { 22, Problem022 },
            { 23, Problem023 },
            { 25, Problem025 },
            { 27, Problem027 },
            { 28, Problem028 },
            { 29, Problem029 },
            { 30, Problem030 },
            { 31, Problem031 },
            { 35, Problem035 },
            { 36, Problem036 },
            { 37, Problem037 },
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