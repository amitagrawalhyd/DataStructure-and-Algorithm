using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OtherCodePractive.Problems
{
    public class FirstNoneRecurringCharacter
    {
        private int[] _numberArray;

        public FirstNoneRecurringCharacter()
        {
            _numberArray = new[] { 1, 2, 3, 4, 5, 1, 2 };
        }

        public FirstNoneRecurringCharacter(int[] numberArray)
        {
            _numberArray = numberArray;
        }

        public int? GetFirstNoneRecurringCharacterSolution0()
        {
            int j;
            for (int i = 0; i < _numberArray.Length; i++)
            {
                for (j = 0; j < _numberArray.Length; j++)
                    if(i != j)
                        if (_numberArray[i] == _numberArray[j])
                            break;

                if (j == _numberArray.Length)
                    return _numberArray[i];
            }
            return null;
        }

        public int? GetFirstNoneRecurringCharacterSolution1()
        {
            Hashtable hs = new Hashtable();
            for (int i = 0; i < _numberArray.Length; i++)
            {
                if (hs.ContainsKey(_numberArray[i]))
                    hs[_numberArray[i]] = true;
                else
                    hs.Add(_numberArray[i], false);
            }

            for (int i = 0; i < _numberArray.Length; i++)
                if (Convert.ToBoolean(hs[_numberArray[i]]) == false)
                    return _numberArray[i];

            return null;
        }

        public int? GetFirstNoneRecurringCharacterSolution2()
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < _numberArray.Length; i++)
            {
                if (dict.ContainsKey(_numberArray[i]))
                    dict[_numberArray[i]]++;
                else
                    dict.Add(_numberArray[i], 1);
            }

            return dict.Where(d => d.Value == 1).Select(d => d.Key).FirstOrDefault();
        }
    }
}
