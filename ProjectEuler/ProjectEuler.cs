using System.Diagnostics;

namespace ProjectEuler
{
    public static partial class ProjectEuler
    {
        public static Dictionary<int, Func<long>> Problems = new Dictionary<int, Func<long>>()
        {
            { 7, Problem7 } 
        };

        public static long CalculateAnswer(int problemNumber)
        {
            if (!Problems.ContainsKey(problemNumber))
            {
                Console.WriteLine("Problem " + problemNumber.ToString() + " is not implemented");
                return -1;
            }

            return Problems[problemNumber]();
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