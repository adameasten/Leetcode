using Xunit;

var expected = "bb";
var result = LongestPalindrome("cbbd");
Assert.Equal(expected, result);

static string LongestPalindrome(string s)
{
    var strlen = s.Length;

    var result = string.Empty;
    var resultLength = 0;

    for (int i = 0; i < strlen; i++)
    {
        var rightIndex = i;
        var leftIndex = i;

        while (leftIndex >= 0 && rightIndex < strlen && (s[rightIndex] == s[leftIndex]))
        {
            var substringLength = rightIndex - leftIndex + 1;
            if (substringLength > resultLength)
            {
                result = s.Substring(leftIndex, substringLength);
                resultLength = substringLength;
            }

            rightIndex++;
            leftIndex--;
        }
        
        //Even numbers
        rightIndex = i + 1;
        leftIndex = i;

        while (leftIndex >= 0 && rightIndex < strlen && (s[rightIndex] == s[leftIndex]))
        {
            var substringLength = rightIndex - leftIndex + 1;
            if (substringLength > resultLength)
            {
                result = s.Substring(leftIndex, substringLength);
                resultLength = substringLength;
            }

            rightIndex++;
            leftIndex--;
        }
    }

    return result;
}