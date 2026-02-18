using System.Collections.Generic;
using System.Linq;

public class Solution 
{
    public int RemoveDuplicates(int[] nums) 
    {
        // Leetcode #26
        // This is an incredibly poorly phrased problem.
        // It also allows you to apparently not even actually replace the array in-place, 
        // but use a separate collection to keep track of unique values. I guess by using 
        // their expected names this somehow passes. 

        // Note: Problem #27 is equally as strange. 
        // Below is how I would solve #26 in a normal way, which would just be the first 
        // foreach loop. 
        // The only reason there's another loop is because of the weird requirement to 
        // return the original array with the unique values at the beginning and the remaining 
        // values left as they were.

        // Getting an array like `int[] nums = new int[] {1, 1, 2};`
        // and returning it as `int[] nums = new int[] {1, 2, 2};` with a return value of 2 
        // is strange. Why not return new int[] {1, 2};?`
        // I don't see the actual practical application of this, if I want unique values then 
        // why return the original array with its original length and essentially junk data 
        // after a certain point? I don't see why anyone would ever want to handle data like 
        // this when you can't actually remove duplicates from an array in-place.

        var uniqueNums = new HashSet<int>();

        foreach(var num in nums)
        {
            if(!uniqueNums.Contains(num))
            {
                uniqueNums.Add(num);
            }
        }
        
        var expectedNums = uniqueNums.ToArray();

        for(var index = 0; index < expectedNums.Length; index++)
        {
            nums[index] = expectedNums[index];
        }

        return uniqueNums.Count;
    }
}