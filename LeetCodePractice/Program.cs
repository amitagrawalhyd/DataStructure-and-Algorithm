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
    }
}
