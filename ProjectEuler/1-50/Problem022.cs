using ProjectEuler.Utilities;
using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection;

namespace ProjectEuler
{
    public static partial class ProjectEuler
    {
        private static readonly Dictionary<char, int> AlphabeticalValueDictionary = GenerateAlphabeticalValueDictionary();

        /// <summary>
        /// <see href="https://projecteuler.net/problem=22"/>
        /// </summary>
        public static long Problem022()
        {
            const string resourceName = "ProjectEuler._1_50.p022_names.txt";
            long nameScore;
            long totalScore = 0;
            List<string> names = GetNamesFromFile(Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName));
            names.Sort();

            for (int i = 0; i < names.Count; i++)
            {
                nameScore = 0;
                foreach(char c in names[i])
                {
                    nameScore += AlphabeticalValueDictionary[c];
                }

                nameScore = (i + 1) * nameScore;
                totalScore += nameScore;
            }

            return totalScore;
        }

        private static Dictionary<char, int> GenerateAlphabeticalValueDictionary()
        {
            Dictionary<char, int> alphabeticalValueDictionary = new();

            for (int i = 65; i < 91; i++)
            {
                alphabeticalValueDictionary.Add((char)i, i - 64);
            }
            for (int i = 97; i < 123; i++)
            {
                alphabeticalValueDictionary.Add((char)i, i - 96);
            }

            return alphabeticalValueDictionary;
        }

        private static List<string> GetNamesFromFile(Stream stream)
        {
            string content;

            if (stream != null)
            {
                content = new StreamReader(stream).ReadToEnd();
            }
            else
            {
                throw new FileNotFoundException();
            }

            return content.Replace("\"", string.Empty).Split(',').ToList();
        }

        private static List<string> GetNamesFromFile(string filePath)
        {
            string content;

            if (File.Exists(filePath))
            {
                content = File.ReadAllText(filePath);
            }
            else
            {
                throw new FileNotFoundException(filePath);
            }

            return content.Replace("\"", string.Empty).Split(',').ToList();
        }
    }
}
