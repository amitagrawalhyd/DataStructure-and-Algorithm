using LeetCodePractice.Problems;
using System;

namespace LeetCodePractice
{
    class Program
    {
        static void Main()
        {
            CheckTwoSum();
            MaximumSubArraySum();
            MoveZeroesToEnd();
            ContainsDuplicate();
            RotateArray();
        }

        private static void CheckTwoSum()
        {
            var inputArray = new []{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 } ;
            var twoSumSolution0Result = new TwoSum(inputArray, 20).GetTwoSumSolution0Result();
            var twoSumSolution1Result = new TwoSum(inputArray, 15).GetTwoSumSolution1Result();
            var twoSumSolution2Result = new TwoSum(inputArray, 14).GetTwoSumSolution2Result();

            Console.WriteLine("Two Sum:");
            Console.WriteLine($"Input Array :{string.Join(',', inputArray)}");
            Console.WriteLine($"Target : 20 - GetTwoSumSolution0Result :- {string.Join(',', twoSumSolution0Result)}");
            Console.WriteLine($"Target : 15 - GetTwoSumSolution1Result :- {string.Join(',', twoSumSolution1Result)}");
            Console.WriteLine($"Target : 14 - GetTwoSumSolution2Result :- {string.Join(',', twoSumSolution2Result)}");
        }

        private static void MaximumSubArraySum()
        {
            var inputArray = new [] { -1,-2,10,8,1,-20,20,1,2,-10,-15 };
            var maxSubArraySumSolution0Result = new MaximumSubArray(inputArray).GetMaximumSubArraySolution0Result();
            var maxSubArraySum1Result = new MaximumSubArray(inputArray).GetMaximumSubArraySolution1Result();

            Console.WriteLine("Maximum Sub array Sum:");
            Console.WriteLine($"Input Array :{string.Join(',', inputArray)}");
            Console.WriteLine($"GetMaximumSubArraySolution0Result :- {maxSubArraySumSolution0Result}");
            Console.WriteLine($"GetMaximumSubArraySolution1Result :- {maxSubArraySum1Result}");
       }

        private static void MoveZeroesToEnd()
        {
            var inputArray = new[] { 1,2,0,5,2,3,6,9,8,0,1,2,3,0,0 };
            Console.WriteLine("Move Zeroes to end:");
            Console.WriteLine($"Input Array :{string.Join(',', inputArray)}");
            new MoveZeroes(inputArray).GetMoveZeroesSolution0Result();
            new MoveZeroes(inputArray).GetMoveZeroesSolution1Result();
            new MoveZeroes(inputArray).GetMoveZeroesSolution2Result();
            new MoveZeroes(inputArray).GetMoveZeroesSolution3Result();
        }

        private static void ContainsDuplicate()
        {
            var inputArray = new[] { -1, -2, 10, 8, 1, -20, 20, 1, 2, -10, -15 };
            var containDuplicateSolution0Result = new ContainsDuplicate(inputArray).ContainDuplicateSolution0Result();
            var containDuplicateSolution1Result = new ContainsDuplicate(inputArray).ContainsDuplicateSolution1Result();
            var containsDuplicateSolution2Result = new ContainsDuplicate(inputArray).ContainsDuplicateSolution2Result();
            var containsDuplicateSolution3Result = new ContainsDuplicate(inputArray).ContainsDuplicateSolution3Result();

            Console.WriteLine("Contains Duplicate:");
            Console.WriteLine($"Input Array :{string.Join(',', inputArray)}");
            Console.WriteLine($"ContainDuplicateSolution0Result :- {containDuplicateSolution0Result}");
            Console.WriteLine($"ContainDuplicateSolution1Result :- {containDuplicateSolution1Result}");
            Console.WriteLine($"ContainsDuplicateSolution2Result :- {containsDuplicateSolution2Result}");
            Console.WriteLine($"ContainsDuplicateSolution3Result :- {containsDuplicateSolution3Result}");
        }

        private static void RotateArray()
        {
            var inputArray = new[] { 1,2,3,4,5,6,7,8,9,10,11,20,21,22 };
            Console.WriteLine("Rotate Array:");
            Console.WriteLine($"Input Array :{string.Join(',', inputArray)}");
            new RotateArray().RotateArraySolution0Result(3, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 20, 21, 22 });
            new RotateArray().RotateArraySolution1Result(13, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 20, 21, 22 });
            new RotateArray().RotateArraySolution2Result(5, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 20, 21, 22 });
            new RotateArray().RotateArraySolution3Result(6, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 20, 21, 22 });
        }
    }
}