namespace TwoSum
{
    internal class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var arrLength = nums.Length;
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < arrLength; i++)
            {
                var current = nums[i];
                var difference = target - current;

                if (dict.TryGetValue(difference, out var value))
                {
                    return new int[] { value, i };
                }

                dict[current] = i;
            }

            return Array.Empty<int>();
        }
    }
}
