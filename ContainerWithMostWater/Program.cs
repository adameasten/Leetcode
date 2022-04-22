using Xunit;

var input = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
var expected = 49;

var result = MaxArea(input);
Assert.Equal(expected, result);

static int MaxArea(int[] height)
{
    int leftIndex = 0;
    int rightIndex = height.Length - 1;
    int maxArea = 0;

    while (leftIndex < rightIndex)
    {
        var leftPillar = height[leftIndex];
        var rightPillar = height[rightIndex];

        var lowest = leftPillar > rightPillar ? rightPillar : leftPillar;
        var area = lowest * (rightIndex - leftIndex);

        if (area > maxArea)
            maxArea = area;

        if (lowest == leftPillar)
            leftIndex++;
        else
            rightIndex--;
    }

    return maxArea;
}