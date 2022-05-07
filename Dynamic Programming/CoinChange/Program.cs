var coins = new int[] { 2 };
var amount = 3;
var result = CoinChange(coins, amount);

static int CoinChange(int[] coins, int finalAmount)
{
    var dp = new int[finalAmount + 1];

    //Skip amount 0, no coin added can lead to that
    for (var amount = 1; amount <= finalAmount; amount++)
    {
        dp[amount] = int.MaxValue;

        foreach (var coin in coins)
        {
            var diff = amount - coin;

            if (diff >= 0 && dp[diff] != int.MaxValue)
            {
                dp[amount] = Math.Min(dp[amount], 1 + dp[diff]);
            }
        }
    }

    var result = dp[finalAmount] != int.MaxValue ?
        dp[finalAmount] :
        -1;

    return result;
}