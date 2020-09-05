using System.Linq;

namespace LeetCodePractice.Problems
{
    public class MaximumSubArray
    {
        private int[] _numberArray;

        public MaximumSubArray()
        {
            _numberArray = new[]{ -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        }

        public MaximumSubArray(int[] numberArray)
        {
            _numberArray = numberArray;
        }

        public int GetMaximumSubArraySolution0Result(int[] numberArray = null)
        {
            _numberArray = numberArray ?? _numberArray;

            int maxSoFar = int.MinValue,
                maxEndingHere = 0;

            for (int i = 0; i < _numberArray.Count(); i++)
            {
                maxEndingHere = maxEndingHere + _numberArray[i];

                if (maxSoFar < maxEndingHere)
                    maxSoFar = maxEndingHere;

                if (maxEndingHere < 0)
                    maxEndingHere = 0;
            }

            return maxSoFar;
        }

        public int GetMaximumSubArraySolution1Result(int[] numberArray = null)
        {
            _numberArray = numberArray ?? _numberArray;

            int maxSoFar = _numberArray.Max(),
                maxEndingHere = 0;

            for (int i = 0; i < _numberArray.Count(); i++)
            {
                maxEndingHere = maxEndingHere + _numberArray[i];

                if (maxEndingHere < 0)
                    maxEndingHere = 0;
                else if (maxSoFar < maxEndingHere)
                    maxSoFar = maxEndingHere;
            }

            return maxSoFar;
        }
    }
}
