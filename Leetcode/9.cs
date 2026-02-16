public class Solution 
{
    public bool IsPalindrome(int x) 
    {
        var result = x > 0 ? true : false;
        var stringNumber = x.ToString();

        // I guess some Leetcode problems are either really length, or are like this 
        // where the details are fairly minimal. A single number / character wouldn't
        // be considered a palindrome, so let's skip that.

        if(x > 0 && stringNumber.Length >= 2)
        {
            // Check for palindrome by working from the very beginning and very end until 
            // we meet in the middle. Break out of the loop at the first occurrence of a mismatch.
           
            var rightIndex = stringNumber.Length - 1;

            for(var index = 0; index <= rightIndex; index++)
            {
                if(stringNumber[index] != stringNumber[rightIndex])
                {
                    result = false;
                    break;
                }

                rightIndex--;
            }
        }
        
        return result;  
    }
}