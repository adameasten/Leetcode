using System;
namespace LongestSubstring
{
    internal class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var longestSubString = 0;
            var strlen = s.Length;
            var set = new HashSet<char>();
            int windowStartIndex = 0;

            for (int windowEndIndex = 0; windowEndIndex < strlen; windowEndIndex++)
            {
                while (set.Contains(s[windowEndIndex]))
                {
                    set.Remove(s[windowStartIndex]);
                    windowStartIndex++;
                }

                set.Add(s[windowEndIndex]);

                if (set.Count > longestSubString)
                {
                    longestSubString = set.Count;
                }
            }

            return longestSubString;
        }
    }
}
