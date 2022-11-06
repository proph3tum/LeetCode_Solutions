// https://leetcode.com/problems/richest-customer-wealth/

namespace LeetCode_Solutions;

public static class RichestCustomerWealth
{
	private static int MaxValue(int[][] accounts)
	{
		var res = 0;
		foreach (var t in accounts)
		{
			var temporary = 0;
			foreach (var t1 in t) temporary += t1;
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