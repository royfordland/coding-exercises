public class Solution 
{
    public int SearchInsert(int[] nums, int target) 
    {
        if (nums.Contains(target))
        {
            return nums.ToList().IndexOf(target);
        }
        else
        {
            var lastValue = -1;
            var currentValue = -1;

            var result = -1;

            for (int index = 0; index < nums.Length; index++)
            {
                currentValue = nums[index];
                lastValue = index > 0 ? nums[index - 1] : -1;

                if (target > lastValue && target < currentValue)
                {
                    result = index;
                    break;
                }
            }

            // If the target hasn't been found and result is still -1, then the target
            // is either greater than all the elements (in case it's a positive number) or less
            // than all the elements (in case it's a negative number).
            // I found out about this during the submission of the code when 1 test case failed.
            // I had accounted for the positive case, but not for the negative case (if smaller than
            // anything else, the index should be 0)
            if (result == -1)
            {
            	result = target > 0 ? nums.Length : 0;
            }

            return result;
        }
    }
}