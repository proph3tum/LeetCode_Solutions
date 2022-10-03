namespace LeetCodeSolution;

public static class RichestCustomerWealth
{
	private static int MaxValue(int[][] accounts)
	{
		var res = 0;
		for (var i = 0; i < accounts.Length; i++)
		{
			var temporary = 0;
			for (var j = 0; j < accounts[i].Length; j++)
			{
				temporary += accounts[i][j];
			}

			res = Math.Max(res, temporary);
		}

		return res;
		// return accounts.Max(x => x.Sum());
	}

	private static void Main()
	{
		int[][] accounts = { new int[] { 1, 2, 3 }, new[] { 3, 2, 1 } };
		Console.WriteLine(MaxValue(accounts));
	}
}