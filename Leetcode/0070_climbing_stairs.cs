public class Solution
{
	public int ClimbStairs(int n)
	{
		if (n <= 2)
		{
			return n;
		}

		// alright, let's type this whole scenario out.

		// n = 1 has 1 way to climb;
		// 1

		// n = 2 has 2 ways to climb;
		// either 2
		// or 1 + 1

		// but at n = 1 or 2 we know it's either 1 or 2 respectively,
		// so we will return that same number immediately. we only care
		// about 3 and above

		// so, below;
		// - waysToClimb will hold the result for the current counter position, which will be the
		//   sum of waysToClimbMinus1 and waysToClimbMinus2
		// - waysToClimbMinus1 will hold the result for (counter - 1)
		// - waysToClimbMinus2 will hold the result for (counter - 2)

		int counter = 3;
		int totalWaysToClimb = 0;
		int waysToClimbMinus1 = counter - 1;
		int waysToClimbMinus2 = counter - 2;

		// n = 3 has 3 ways to climb;
		// either 2 + 1
		// or 1 + 2
		// or 1 + 1 + 1
		// waysToClimbMinus2 = 2
		// waysToClimbMinus1 = 3

		// n = 4 has 5 ways to climb;
		// either 2 + 2
		// or 2 + 1 + 1
		// or 1 + 2 + 1
		// or 1 + 1 + 2
		// or 1 + 1 + 1 + 1
		// waysToClimbMinus2 = 3
		// waysToClimbMinus1 = 5

		// n = 5 has 8 ways to climb;
		// either 2 + 2 + 1
		// or 2 + 1 + 2
		// or 1 + 2 + 2
		// or 2 + 1 + 1 + 1
		// or 1 + 2 + 1 + 1
		// or 1 + 1 + 2 + 1
		// or 1 + 1 + 1 + 2
		// or 1 + 1 + 1 + 1 + 1
		// waysToClimbMinus2 = 5
		// waysToClimbMinus1 = 8

		// etc. etc. etc.
		// in the end with every time we loop waysToClimbMinus1 will get set to the
		// highest possible number of steps, and waysToClimbMinus2 will be set to the
		// what waysToClimbMinus1 previously contained.
		// so as seen for n = 3 above, waysToClimbMinus1 will get set to 3 (because 1 + 2),
		// waysToClimbMinus2 will get set to 2 (because n = 2 only had 2 options).
		// next loop waysToClimbMinus1 will be set to 5 (because 2 + 3), and
		// waysToClimbMinus2 will get set to 3 because that's what waysToClimbMinus1 previously contained.

		while (counter <= n)
		{
			totalWaysToClimb = waysToClimbMinus1 + waysToClimbMinus2;
			waysToClimbMinus2 = waysToClimbMinus1;
			waysToClimbMinus1 = totalWaysToClimb;
			counter++;
		}

		return totalWaysToClimb;
	}
}