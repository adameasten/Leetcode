using LongestSubstring;
using Xunit;

var solution = new Solution();
var expected = 3;

var result = solution.LengthOfLongestSubstring("abcabcbb");

Assert.Equal(expected, result);
