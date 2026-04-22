using System;
using System.Linq;
using System.Text;

public class Solution
{
	// My original solution was the following method below.
	// Problem here was that 1 of the test cases on the Leetcode site uses really long binary
	// strings that exceed the maximum value of a long (64 bits), and therefor can't be parsed
	// through the Convert.ToString method at the very end.
	//public string AddBinary(string a, string b)
	//{
	//	var num1 = Convert.ToInt64(a, 2);
	//	var num2 = Convert.ToInt64(b, 2);
	//	var sum = num1 + num2;

	//	return Convert.ToString(sum, 2);
	//}

	// So, instead I used a little bit of Copilot magic to help me write the methods to parse
	// the binary strings into BigInteger values, and then convert the sum back to a binary string.

	public string AddBinary(string a, string b)
	{
		BigInteger num1 = a.Aggregate(BigInteger.Zero, (x, y) => (x << 1) + y - '0');
		BigInteger num2 = b.Aggregate(BigInteger.Zero, (x, y) => (x << 1) + y - '0');

		var sum = num1 + num2;

		return ToBinary(sum);
	}

	private string ToBinary(BigInteger value)
	{
		if (value == 0)
		{
			return "0";
		}

		var bits = new StringBuilder();

		while (value > 0)
		{
			bits.Insert(0, (value & 1) == 1 ? '1' : '0');
			value >>= 1;
		}

		return bits.ToString();
	}
}