using Xunit;

var input = new int[] { 1, 2, 3, 4 };
var result = ProductExceptSelf(input);
var expected = new int[] { 24, 12, 8, 6 };

Assert.Equal(expected, result);

static int[] ProductExceptSelf(int[] nums)
{
    var result = new int[nums.Length];
    var preNumSum = 1;
    var postNumSum = 1;

    for (int i = 0; i < nums.Length; i++)
    {
        result[i] = preNumSum;
        preNumSum *= nums[i];
    }

    for (int i = nums.Length - 1; i >= 0; i--)
    {
        result[i] *= postNumSum;
        postNumSum *= nums[i];
    }

    return result;
}