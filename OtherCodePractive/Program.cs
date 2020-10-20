using System;
using OtherCodePractive.Problems;

namespace OtherCodePractive
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckFirstRecurringCharacter();
            CheckFirstNoneRecurringCharacter();
        }

        private static void CheckFirstRecurringCharacter()
        {
            var inputArray = new[] { 1,2,2,1,3,4,5,6,7,8,9,1 };
            var result0 = new FirstRecurringCharacter(inputArray).GetFirstRecurringCharacterSolution0()?.ToString()??"N/A";
            var result1 = new FirstRecurringCharacter(inputArray).GetFirstRecurringCharacterSolution1()?.ToString()??"N/A";
            var result2 = new FirstRecurringCharacter(inputArray).GetFirstRecurringCharacterSolution2()?.ToString()??"N/A";

            Console.WriteLine("First Recurring Characters:");
            Console.WriteLine($"Input Array :{string.Join(',', inputArray)}");
            Console.WriteLine($"GetFirstRecurringCharacterSolution0 :- {result0}");
            Console.WriteLine($"GetFirstRecurringCharacterSolution1 :- {result1}");
            Console.WriteLine($"GetFirstRecurringCharacterSolution2 :- {result2}");
        }

        private static void CheckFirstNoneRecurringCharacter()
        {
            var inputArray = new[] { 1, 2, 2, 1, 3, 4, 5, 6, 7, 8, 9, 1 };
            var result0 = new FirstNoneRecurringCharacter(inputArray).GetFirstNoneRecurringCharacterSolution0()?.ToString() ?? "N/A";
            var result1 = new FirstNoneRecurringCharacter(inputArray).GetFirstNoneRecurringCharacterSolution1()?.ToString() ?? "N/A";
            var result2 = new FirstNoneRecurringCharacter(inputArray).GetFirstNoneRecurringCharacterSolution2()?.ToString() ?? "N/A";

            Console.WriteLine("First None Recurring Characters:");
            Console.WriteLine($"Input Array :{string.Join(',', inputArray)}");
            Console.WriteLine($"GetFirstNoneRecurringCharacterSolution0 :- {result0}");
            Console.WriteLine($"GetFirstNoneRecurringCharacterSolution1 :- {result1}");
            Console.WriteLine($"GetFirstNoneRecurringCharacterSolution2 :- {result2}");
        }
    }
}
