using System.Collections.Generic;

namespace LeetCodePractice.Problems
{
    public class ContainsDuplicate
    {
        private int[] _numberArray;

        public ContainsDuplicate(int[] numberArray)
        {
            _numberArray = numberArray;
        }

        public ContainsDuplicate()
        {
            _numberArray = new[] {1, 1, 3, 4, 5, 6, 7};
        }

        public bool ContainDuplicateSolution0Result(int[] numberArray = null)
        {
            _numberArray = numberArray ?? _numberArray;

            if (_numberArray?.Length <= 1)
                return false;
            else
            {
                for(int i = 0; i<_numberArray?.Length; i++)
                    for(int j = i+1; j< _numberArray?.Length; j++)
                        if (_numberArray[i] == _numberArray[j])
                            return true;
            }

            return false;
        }

        public bool ContainsDuplicateSolution1Result(int[] numberArray = null)
        {
            _numberArray = numberArray ?? _numberArray;

            if (_numberArray?.Length <= 1)
                return false;
            else
            {
                for (int i = 0; i < _numberArray?.Length; i++)
                {
                    var index = i + 1;
                    while (index < _numberArray.Length)
                    {
                        if (_numberArray[i] == _numberArray[index])
                            return true;

                        index++;
                    }
                }

            }

            return false;
        }

        public bool ContainsDuplicateSolution2Result(int[] numberArray = null)
        {
            _numberArray = numberArray ?? _numberArray;

            Dictionary<int,bool> numbers = new Dictionary<int, bool>();

            if (_numberArray?.Length <= 1)
                return false;
            else
            {
                for (int i = 0; i < _numberArray?.Length; i++)
                {
                    if (numbers.ContainsKey(_numberArray[i]))
                        return true;
                    else
                    {
                        numbers.Add(_numberArray[i], true);
                    }
                }

            }

            return false;
        }

        public bool ContainsDuplicateSolution3Result(int[] numberArray = null)
        {
            _numberArray = numberArray ?? _numberArray;

            var hs = new HashSet<int>();
            
            foreach (var t in _numberArray)
                if (hs.Contains(t))
                    return true;
                else
                    hs.Add(t);

            return false;

            //var hs = new HashSet<int>();
            //for (int i = 0; i < _numberArray.Length; i++)
            //    if (hs.Contains(_numberArray[i]))
            //        return true;
            //    else
            //        hs.Add(_numberArray[i]);

            //return false;
        }
    }
}
