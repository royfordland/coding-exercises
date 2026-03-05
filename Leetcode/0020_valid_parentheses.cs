public class Solution 
{
	// 20 - Valid Parentheses
	// First of all the title of the problem is entirely incorrect. "Valid parentheses" implies we're dealing with parentheses,
	// yet the problem also includes square brackets and curly braces.
	// Second, this is classified as "Easy", when "Medium" would be more appropriate. 

	// The IsValid method is what I wrote initially. My solution was to keep track of the closing brackets on a string variable.
	// When we come across a closing bracket, we check if it matches the last character in the closing brackets string. If it does,
	// then it's valid, and we remove this character. If it doesn't match it's not a valid string and we should break out of
	// the loop immediately. At the end we need to confirm that all found closing brackets have successfully been match meaning
	// the closing brackets variable should be empty.

	// The IsValid2 method is what I got when I prompted Copilot with the following prompt:
	// "Please solve Leetcode problem #20". 
	// The fact it even knows about Leetcode, this problem, and is able to spit out a solution proves how asking these types
	// of questions or having these types of exercises during interviews in the age of AI is pretty much pointless. 

	// The solution Copilot came up with similar to what I wrote, but instead uses a stack to keep track of things.	
	// Can't say that I've ever had to use "Stack" for anything in the past. Good to learn about it, and I guess if this ever
	// came up in an interview it would be good to know about it, but I don't see it as being a common data structure that I 
	// would need to use in the future. So far in 15+ years I've never had to use it. 
    
	public bool IsValid(string s) 
	{
		var closingBrackets = "";

		// We're checking for valid brackets, so odd numbers are all invalid and will return false in the else block.
		if (s.Length % 2 == 0)
		{
			// Now we need to keep track of the closing brackets.
			foreach (var bracket in s)
			{
				switch (bracket)
				{
					case '(':
						closingBrackets += ")";
						break;

					case '[':
						closingBrackets += "]";
						break;

					case '{':
						closingBrackets += "}";
						break;

					default:
						if (closingBrackets.Length == 0 || closingBrackets.Substring(closingBrackets.Length - 1, 1) != bracket.ToString())
						{
							// If there's no matching expected bracket or it doesn't match, invalid, return false here.
							return false;
						}
						else
						{
							// Remove the last character from the closing brackets string in case it matches, we've found a correct / matching closing bracket!
							closingBrackets = closingBrackets.Substring(0, closingBrackets.Length - 1);
						}
						break;
				}
			}
		}
		else
		{
			return false;
		}

		// All brackets must be matched after completing the foreach, so the closing brackets string should be empty.
		return string.IsNullOrEmpty(closingBrackets);
	}

	// LeetCode #20 - Valid Parentheses
	// The Copilot solution:
	public static bool IsValid2(string s)
	{
		if (string.IsNullOrEmpty(s))
			return true;

		if ((s.Length & 1) == 1)
			return false;

		var stack = new Stack<char>();

		foreach (var ch in s)
		{
			switch (ch)
			{
				case '(':
					stack.Push(')');
					break;

				case '[':
					stack.Push(']');
					break;

				case '{':
					stack.Push('}');
					break;

				default:
					if (stack.Count == 0 || stack.Pop() != ch)
						return false;
					break;
			}
		}

		return stack.Count == 0;
	}
}