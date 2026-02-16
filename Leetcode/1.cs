using System;

public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        var result = new int[2];

        for(var index = 0; index < nums.Length; index++)
        {
            // Since it's only ever 2 items my first idea is to subtract the value at the current 
            // index from the target and check to see if nums contains an index for the remainder. 
            // If so, return the indices, if not keep going.
            // Was thinking of sorting nums first, but that would just complicate finding the indices.

            var remainder = target - nums[index];
            var secondIndex = Array.IndexOf(nums, remainder);

            if(secondIndex > -1 && secondIndex != index)
            {
                result = [index, secondIndex];
                break;
            }            
        }

        return result;
    }
}