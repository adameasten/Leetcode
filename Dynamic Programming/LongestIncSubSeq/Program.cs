using Xunit;

var input = new int[] { 1, 2, 4, 3 };
var result = LengthOfLIS(input);
var expected = 3;

Assert.Equal(expected, result);

static int LengthOfLIS(int[] nums)
{
    var longestLenght = 1;
    var longestIncSubSeqs = new int[nums.Length];

    //Bottom up, last value already assigned
    for (int currentInputValue = nums.Length - 1; currentInputValue >= 0; currentInputValue--)
    {
        longestIncSubSeqs[currentInputValue] = 1;        
        //Check for subsequences in array
        for (int postCurrentInputValue = currentInputValue + 1; postCurrentInputValue < nums.Length; postCurrentInputValue++)
        {
            //if current value is less than any value post it in array
            //compare current values longest subsequence with larger values
            //computed longest subsequence.
            if (nums[currentInputValue] < nums[postCurrentInputValue])
            {
                longestIncSubSeqs[currentInputValue] = Math.Max(longestIncSubSeqs[currentInputValue], 1 + longestIncSubSeqs[postCurrentInputValue]);
            }

            longestLenght = Math.Max(longestLenght, longestIncSubSeqs[currentInputValue]);
        }
    }

    return longestLenght;
}