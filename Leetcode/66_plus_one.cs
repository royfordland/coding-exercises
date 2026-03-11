public class Solution
{
	public int[] PlusOne(int[] digits)
	{
		var stringNumber = string.Join("", digits);
		var number = BigInteger.Parse(stringNumber) + 1;
		stringNumber = number.ToString();

		var numbersArr = new int[stringNumber.Length];

		for (var index = 0; index < stringNumber.Length; index++)
		{
			numbersArr[index] = int.Parse(stringNumber[index].ToString());
		}

		return numbersArr;
	}
}