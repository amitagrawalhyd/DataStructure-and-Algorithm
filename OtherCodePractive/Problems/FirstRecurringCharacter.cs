using System.Collections;
using System.Collections.Generic;

namespace OtherCodePractive.Problems
{
    public class FirstRecurringCharacter
    {
        private int[] _numberArray;

        public FirstRecurringCharacter()
        {
            _numberArray = new[]{1,2,3,4,5,1,2};
        }

        public FirstRecurringCharacter(int[] numberArray)
        {
            _numberArray = numberArray;
        }

        public int? GetFirstRecurringCharacterSolution0()
        {
            for(int i=0; i<_numberArray.Length ; i++)
                for(int j = i+1; j<_numberArray.Length; j++)
                    if (_numberArray[i] == _numberArray[j])
                        return _numberArray[i];
            return null;
        }

        public int? GetFirstRecurringCharacterSolution1()
        {
            Hashtable hs = new Hashtable();
            for (int i = 0; i < _numberArray.Length; i++)
                if (hs.ContainsKey(_numberArray[i]))
                    return _numberArray[i];
                else
                    hs.Add(_numberArray[i],1);
            return null;
        }

        public int? GetFirstRecurringCharacterSolution2()
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < _numberArray.Length; i++)
                if (dict.ContainsKey(_numberArray[i]))
                    return _numberArray[i];
                else
                    dict.Add(_numberArray[i], 1);
            return null;
        }
    }
}
