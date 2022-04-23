using Xunit;

var input = new int[] { -1, 0, 1, 2, -1, -4 };
var expected = new int[][]
{
    new int[] { -1, -1, 2 },
    new int[] { -1, 0, 1 },
};

var result = ThreeSum(input);
Assert.Equal(expected, result);

static IList<IList<int>> ThreeSum(int[] nums)
{
    Array.Sort(nums);

    var arrLength = nums.Length - 1;
    var result = new List<IList<int>>();

    for (int i = 0; i < arrLength; i++)
    {
        //Same value as before
        //Skip to eliminate dupes
        if (i > 0 && nums[i - 1] == nums[i])
            continue;

        var number = nums[i];
        var firstIdx = i + 1;
        var secIdx = arrLength;

        while (firstIdx < secIdx)
        {
            var sum = number + nums[firstIdx] + nums[secIdx];
            if (sum > 0)
            {
                secIdx--;
            }
            else if (sum < 0)
            {
                firstIdx++;
            }
            else
            {
                result.Add(new int[] { number, nums[firstIdx], nums[secIdx] });
                firstIdx++;
                while (nums[firstIdx] == nums[firstIdx - 1] && firstIdx < secIdx)
                    firstIdx++;
            }
        }
    }

    return result;
}