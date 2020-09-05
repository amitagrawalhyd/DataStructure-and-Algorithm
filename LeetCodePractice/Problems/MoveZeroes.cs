using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems
{
    public class MoveZeroes
    {
        private int[] _numberArray;

        public MoveZeroes(int[] numberArray)
        {
            _numberArray = numberArray;
        }

        public MoveZeroes()
        {
            _numberArray = new[] {0, 1, 0, 3, 12};
        }

        public void GetMoveZeroesSolution0Result(int[] numberArray = null)
        {
            _numberArray = numberArray ?? _numberArray;

            if (_numberArray?.Length > 1)
            {
                int position = 0;

                for (int i = 0; i < _numberArray.Length; i++)
                {
                    if (_numberArray[i] != 0)
                    {
                        _numberArray[position++] = _numberArray[i];
                    }
                }

                for (int i = position; i < _numberArray.Length; i++)
                    _numberArray[i] = 0;
            }

            Console.WriteLine(string.Join(',',_numberArray));
        }

        public void GetMoveZeroesSolution1Result(int[] numberArray = null)
        {
            _numberArray = numberArray ?? _numberArray;

            if (_numberArray?.Length > 1)
            {
                for (int i = 0; i < _numberArray.Length; i++)
                {
                    if (_numberArray[i] != 0)
                        continue;
                    else
                    {
                        int j = i + 1;
                        while (j < _numberArray.Length)
                        {
                            if (_numberArray[j] != 0)
                            {
                                _numberArray[i] = _numberArray[j];
                                _numberArray[j] = 0;
                                break;
                            }
                            j++;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(',', _numberArray));
        }

        public void GetMoveZeroesSolution2Result(int[] numberArray = null)
        {
            _numberArray = numberArray ?? _numberArray;

            if (_numberArray?.Length > 1)
            {
                int index = 0;
                for (int i = 0; i < _numberArray.Length; i++)
                {
                    if (_numberArray[i] != 0)
                    {
                        _numberArray[index++] = _numberArray[i];
                    }
                }

                for (int i = index; i < _numberArray.Length; i++)
                    _numberArray[i] = 0;
            }

            Console.WriteLine(string.Join(',', _numberArray));
        }

        public void GetMoveZeroesSolution3Result(int[] numberArray = null)
        {
            _numberArray = numberArray ?? _numberArray;

            if (_numberArray?.Length > 1)
            {
                var seensofar = 0;
                for (int i = 0; i < _numberArray.Length; i++)
                {
                    if (_numberArray[i] == 0)
                        seensofar++;
                    else
                        _numberArray[i - seensofar] = _numberArray[i];

                    if (seensofar == _numberArray.Length) return;

                    if (i == _numberArray.Length - 1)
                    {
                        for (var k = i - seensofar + 1; k < _numberArray.Length; k++)
                            _numberArray[k] = 0;
                    }
                }
            }

            Console.WriteLine(string.Join(',', _numberArray));
        }
    }
}
