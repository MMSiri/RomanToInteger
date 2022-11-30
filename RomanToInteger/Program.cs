// See https://aka.ms/new-console-template for more information
using System.Reflection;

public class Solution
{
    public static void Main()
    {
        var test = new Solution();
        Console.WriteLine(test.RomanToInt("MCMXCIV"));
    }

    public int RomanToInt(string s)
    {
        var c = s.ToCharArray();
        int result = 0;
        var roman = new Dictionary<char, int>()
        {
            { 'I',1 },{'V',5}, {'X',10}, {'L',50},{'C',100},{'D',500},{'M',1000},
        };

        for (int i = 0; i < c.Length; i++)
        {
            if (i + 1 < c.Length && roman[c[i]] < roman[c[i + 1]]) result -= roman[c[i]];
            else result += roman[c[i]];
        }

        return result;
    }
}

