using System.Linq;

// Common prefix, so all words should start with at least the same letter, right?
// Once again it's a vaguely worded problem, so I'm going with not just some words
// matching, but everything needs to match. The problem also states
// `strs[i] consists of only lowercase English letters if it is non-empty.`
// So if there are any entries that are just white spaces, then there's also no common prefix.
// Going off of all this, we should be able to sort the incoming array, and only compare
// the first and last values, because everything else between there should have the common prefix
// as well.

public class Solution 
{
    public string LongestCommonPrefix(string[] strs) 
    {
        var commonPrefix = "";

        if(!strs.Where(x => x.Trim() == "").Any())
        {
            var sorted = strs.OrderBy(x => x).ToArray();
            var first = sorted[0];
            var last = sorted[sorted.Length - 1];
            var maxIndex = first.Length > last.Length ? last.Length - 1 : first.Length - 1;

            for(var index = 0; index <= maxIndex; index++)
            {
                if(first[index] == last[index])
                {
                    commonPrefix += first[index];
                }
                else
                {
                    break;
                }
            }
        }        

        return commonPrefix;
    }
}