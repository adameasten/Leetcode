using Xunit;

var expected = 3;
var result = ClimbStairs(3);

Assert.Equal(expected, result);

static int ClimbStairs(int n)
{
    var one = 1;
    var two = 1;

    for (int i = 0; i < n - 1; i++)
    {
        var temp = one;
        one += two;
        two = temp;
    }

    return one;
}