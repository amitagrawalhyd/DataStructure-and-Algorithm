using System.Collections.Generic;
using System.Linq;

namespace LeetCodePractice.Problems
{
    public class TwoSum
    {
        private int[] _numberArray;
        private int _target;

        public TwoSum()
        {
            _numberArray = new[]{ 2, 7, 11, 15 };
            _target = 9;
        }

        public TwoSum(int[] numberArray, int target)
        {
            _numberArray = numberArray;
            _target = target;
        }

        public int[] GetTwoSumSolution0Result(int[] numberArray = null, int? target = null)
        {
            _numberArray = numberArray ?? _numberArray;
            _target = target ?? _target;

            for (int i = 0; i < _numberArray.Count(); i++)
                for(int j = i+1; j< _numberArray.Count(); j++)
                    if(_numberArray[i] + _numberArray[j] == _target)
                        return new []{i,j};
            return null;

        }

        public int[] GetTwoSumSolution1Result(int[] numberArray = null, int? target = null)
        {
            _numberArray = numberArray ?? _numberArray;
            _target = target ?? _target;

            HashSet<int> hs = new HashSet<int>();

            for (int i = 0; i < _numberArray.Count(); i++)
            {
                var complement = _target - _numberArray[i];
                if (hs.Contains(complement))
                {
                    return new []{_numberArray.ToList().IndexOf(complement), i};
                }

                hs.Add(_numberArray[i]);
            }

            return null;

        }

        public int[] GetTwoSumSolution2Result(int[] numberArray = null, int? target = null)
        {
            _numberArray = numberArray ?? _numberArray;
            _target = target ?? _target;

            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 0; i < _numberArray.Count(); i++)
            {
                var complement = _target - _numberArray[i];

                if (dictionary.ContainsKey(complement))
                {
                    return new [] { dictionary[complement], i };
                }

                dictionary.Add(_numberArray[i], i);
            }

            return null;

        }
    }
}
