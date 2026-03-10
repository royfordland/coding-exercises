public class Solution
{
	public int LengthOfLastWord(string s)
	{
		return s.TrimEnd().Length - s.TrimEnd().LastIndexOf(' ') - 1;
	}
}