using Xunit;

var nums = new int[] { 4, 5, 6, 7, 8, 1, 2, 3 };
var result = Search(nums, 8);
var expected = 4;

Assert.Equal(expected, result);

static int Search(int[] nums, int target)
{
    //Modified binary search
    var leftPointer = 0;
    var rightPointer = nums.Length - 1;

    while (leftPointer <= rightPointer)
    {
        var mid = (leftPointer + rightPointer) / 2;

        if (nums[mid] == target)
        {
            return mid;
        }

        //Left sorted portion of array
        if (nums[mid] >= nums[leftPointer])
        {
            if (target > nums[mid] || target < nums[leftPointer])
            {
                leftPointer = mid + 1;
            }
            else
            {
                rightPointer = mid - 1;
            }
        }
        //Right sorted portion
        else
        {
            if (target < nums[mid] || target > nums[rightPointer])
            {
                rightPointer = mid - 1;
            }
            else
            {
                leftPointer = mid + 1;
            }
        }
    }

    return -1;
}