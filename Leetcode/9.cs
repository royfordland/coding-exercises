public class Solution 
{
    public bool IsPalindrome(int x) 
    {
        var result = x >= 0 ? true : false;
        var stringNumber = x.ToString();

        // 0 being a palindrome wasn't mentioned in the problem description but turned up as a test result
        // faiing when submitting the code.

        var rightIndex = stringNumber.Length - 1;

        for(var index = 0; index <= rightIndex; index++)
        {
            // Check for palindrome by working from the very beginning and very end until 
            // we meet in the middle. Break out of the loop at the first occurrence of a mismatch.
            
            if(stringNumber[index] != stringNumber[rightIndex])
            {
                result = false;
                break;
            }

            rightIndex--;
        }
        
        return result;  
    }
}