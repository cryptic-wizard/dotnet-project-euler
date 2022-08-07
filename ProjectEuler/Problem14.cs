using ProjectEuler.Utilities;
using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    public static partial class ProjectEuler
    {
        /// <summary>
        /// <see href="https://projecteuler.net/problem=14"/>
        /// </summary>
        public static long Problem14()
        {
            CollatzSequence collatz = new CollatzSequence();
            const int MAX_VALUE = 1000000;
            long answer = 0;
            long answerLength = 0;
            long length;
            

            for (int i = 1; i < MAX_VALUE; i++)
            {
                length = collatz.GetSequenceLength(i);

                if (length > answerLength)
                {
                    answerLength = length;
                    answer = i;
                }
            }

            return answer;
        }


    }
}
