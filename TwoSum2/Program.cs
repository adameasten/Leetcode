
using Xunit;

var input = new int[] { 1, 3, 4, 5, 7, 10, 11 };
var expected = new int[] { 1, 2 };

var result = TwoSum(input, 4);

Assert.Equal(expected, result);

static int[] TwoSum(int[] numbers, int target)
{
    var arrLenght = numbers.Length - 1;
    int firstPtr = 0;
    int secondPtr = arrLenght;

    while (firstPtr < secondPtr)
    {
        if (numbers[firstPtr] + numbers[secondPtr] == target)
        {
            return new int[] { firstPtr + 1, secondPtr + 1 };
        }
        else if (numbers[firstPtr] + numbers[secondPtr] > target)
        {
            secondPtr--;
        }
        else
        {
            firstPtr++;
        }
    }

    return Array.Empty<int>();
}