using System.Text;

namespace CoderbytePractice.Challenges
{
    public class LongestWord
    {
        private string _sentence;

        public LongestWord(string sentence)
        {
            _sentence = sentence;
        }

        public LongestWord()
        {
            _sentence = "Simplicity is soul of efficiency";
        }

        public string GetLongestWordSolution0Result(string sentence = null)
        {
            _sentence = sentence ?? _sentence;

            string result = string.Empty;
            int longestWordLength = 0;

            var words = _sentence?.Split(" ");

            for(int index = 0; index < words?.Length; index++)
            {
                var word = RemoveSpecialCharacters(words[index]);
                if (longestWordLength < word.Length)
                {
                    result = word;
                    longestWordLength = word.Length;
                }
            }

            return result;
        }

        private string RemoveSpecialCharacters(string word)
        {
            StringBuilder wordWithOutSpecialCharacters = new StringBuilder();

            foreach (char c in word)
            {
                if (char.IsLetter(c) || char.IsDigit(c))
                    wordWithOutSpecialCharacters.Append(c);
            }

            return wordWithOutSpecialCharacters.ToString();
        }
    }
}
