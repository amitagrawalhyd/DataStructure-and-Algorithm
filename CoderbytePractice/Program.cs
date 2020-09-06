using CoderbytePractice.Challenges;
using System;

namespace CoderbytePractice
{
    class Program
    {
        static void Main()
        {
            LongestWord();
        }

        private static void LongestWord()
        {
            var longestWordChallenge = new LongestWord("Simplicity is soul of efficiency");

            Console.WriteLine($"GetLongestWordSolution0Result is {longestWordChallenge.GetLongestWordSolution0Result()}");
        }
    }
}
