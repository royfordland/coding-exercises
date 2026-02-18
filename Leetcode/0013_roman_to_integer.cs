public class Solution 
{
    // First break down the string into values we can lookup.
    // The description mentions all the usual roman numeral rules like II, IV, XL, LX, etc.
    // We don't really care about keep track of II, III, etc. In those cases we can just add all 
    // the single I instances to get to the result. 
    // Determining where things like IV and IX exist is more important. These are essentially
    // all the exceptions where we can't just add the value of I = 1, V = 5, etc straight
    // to the end calculation.

    public int RomanToInt(string s) 
    {
        var numerals = GetNumerals(s);
        var result = 0;

        foreach(var numeral in numerals)
        {
            result += GetNumericValue(numeral);
        }

        return result;
    }

    private List<string> GetNumerals(string s)
    {
        var numerals = new List<string>();
        var maxIndex = s.Length - 1;

        for(var index = 0; index <= maxIndex; index++)
        {
            var nextIndex = index + 1;

            if(nextIndex <= maxIndex &&                
                ((s[index] == 'I' && (s[nextIndex] == 'V' || s[nextIndex] == 'X')) ||
                (s[index] == 'X' && (s[nextIndex] == 'L' || s[nextIndex] == 'C')) ||
                (s[index] == 'C' && (s[nextIndex] == 'D' || s[nextIndex] == 'M'))))
            {
                numerals.Add($"{s[index].ToString()}{s[nextIndex].ToString()}");
                index++;
            }
            else
            {
                numerals.Add(s[index].ToString());
            }
        }

        return numerals;
    }

    private int GetNumericValue(string numeral)
    {
        var numericValue = numeral switch
        {
            "I" => 1,
            "IV" => 4,
            "V" => 5,
            "IX" => 9,
            "X" => 10,
            "XL" => 40,
            "L" => 50,
            "XC" => 90,
            "C" => 100,
            "CD" => 400,
            "D" => 500,
            "CM" => 900,
            "M" => 1000,
            _ => 0
        };

        return numericValue;
    }
}