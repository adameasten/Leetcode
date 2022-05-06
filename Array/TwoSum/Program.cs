using TwoSum;
using Xunit;

var solution = new Solution();

var inputArr = new int[] { 1, 1, 3, 2, 4 };
var inputTarget = 6;
var expected = new int[] { 3, 4 };

var result = solution.TwoSum(inputArr, inputTarget);
Assert.Equal(expected, result);