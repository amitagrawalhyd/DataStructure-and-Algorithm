using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems
{
    public class RotateArray
    {
        private int[] _numberArray;

        public RotateArray()
        {
            _numberArray = new[] { 1,2,3,4,56,1,4,-1,8,7};
        }

        public RotateArray(int[] numberArray)
        {
            _numberArray = numberArray;
        }

        public void RotateArraySolution0Result(int k, int[] numberArray = null)
        {
            _numberArray = numberArray ?? _numberArray;

            if (_numberArray.Length > 0)
            {
                int[] resultArray = new int[_numberArray.Length];
                for (int i = 0; i < _numberArray.Length; i++)
                {
                    resultArray[(i + k) % _numberArray.Length] = _numberArray[i];
                }
                for (int i = 0; i < _numberArray.Length; i++)
                {
                    _numberArray[i] = resultArray[i];
                }
            }

            Console.WriteLine(string.Join(',', _numberArray));
        }

        public void RotateArraySolution1Result(int k, int[] numberArray = null)
        {
            _numberArray = numberArray ?? _numberArray;

            var size = _numberArray.Length;

            if (size > 0)
            {
                k %= size;
                int temp, previous;
                for (int i = 0; i < k; i++)
                {
                    previous = _numberArray[size - 1];
                    for (int j = 0; j < size; j++)
                    {
                        temp = _numberArray[j];
                        _numberArray[j] = previous;
                        previous = temp;
                    }
                }

            }

            Console.WriteLine(string.Join(',', _numberArray));
        }


        public void RotateArraySolution2Result(int k, int[] numberArray = null)
        {
            _numberArray = numberArray ?? _numberArray;

            var size = _numberArray.Length;
            if (size > 0)
            {
                IList<int> resultList = new List<int>(_numberArray);

                for (int i = 0; i < size; i++)
                {
                    _numberArray[(i + k) % size] = resultList[i];
                }

            }

            Console.WriteLine(string.Join(',', _numberArray));
        }

        public void RotateArraySolution3Result(int k, int[] numberArray = null)
        {
            _numberArray = numberArray ?? _numberArray;

            var size = _numberArray.Length;

            int[] resultList = new int[size];

            for (int i = 0; i < size; i++)
                resultList[i] = _numberArray[i];

            for (int index = 0; index < size; index++)
            {
                Console.Write((index + k) % size + "-");
                _numberArray[(index + k) % size] = resultList[index];
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(',', _numberArray));
        }
    }
}
