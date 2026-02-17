public class Solution 
{
    public int RemoveElement(int[] nums, int val) 
    {
        var x = 0;

        for(var index = 0; index < nums.Length; index++)
        {
            if(nums[index] != val)
            {
                nums[x] = nums[index];
                x++;
            }
        }

        // Don't really understand what the purpose is of leaving the values after "removing" 
        // any occurrences of the value passed in for `val` in the nums array.
        // The line below shows that the collection still contains 4 values for test case #1, 
        // so I'm curious what the point really is. In any normal scenario I'd be working with
        // a collection like a list and remove / dedupe / whatever through there. 

        // It's an equally weird problem like #26.

        Console.WriteLine($"nums length = {nums.Length}");
        
        return x;
    }
}