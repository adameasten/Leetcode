var coins = new int[] { 2 };
var amount = 3;
var result = CoinChange(coins, amount);

static int CoinChange(int[] coins, int finalAmount)
{
    var dp = new int[finalAmount + 1];

    for (var currentAmount = 1; currentAmount <= finalAmount; currentAmount++)
    {
        dp[currentAmount] = int.MaxValue;
        foreach (var coin in coins)
        {
            var diff = currentAmount - coin;

            if (diff >= 0 && dp[diff] != int.MaxValue)
            {
                dp[currentAmount] = Math.Min(dp[currentAmount], 1 + dp[diff]);
            }
        }
    }

    if (dp[finalAmount] != int.MaxValue)
        return dp[finalAmount];
    else
        return -1;
}