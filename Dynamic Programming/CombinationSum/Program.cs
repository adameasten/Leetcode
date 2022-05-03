using Xunit;

var expected = new List<int[]> { new int[] { 2, 2, 3 }, new int[] { 7 } };
var result = CombinationSum(new int[] { 2, 3, 6, 7 }, 7).ToList();
Assert.Equal(expected, result);


static List<int[]> CombinationSum(int[] candidates, int target)
{
    var result = new List<int[]>();

    void DepthFirstSearch(int index, IList<int> current, int total)
    {
        if (total == target)
        {
            result.Add(current.ToArray());
            return;
        }

        if (total > target || index >= candidates.Length)
        {
            return;
        }

        current.Add(candidates[index]);
        DepthFirstSearch(index, current, total + candidates[index]);
        current.Remove(candidates[index]);
        DepthFirstSearch(index + 1, current, total);
    }

    DepthFirstSearch(0, new List<int>(), 0);

    return result;
}