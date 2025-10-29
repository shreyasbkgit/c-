using System;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        string result = "";
        bool makeNextUpper = false;

        foreach (char c in identifier)
        {
            if (char.IsControl(c))
            {
                result += "CTRL";
                makeNextUpper = false;
            }
            else if (c == ' ')
            {
                result += "_";
                makeNextUpper = false;
            }
            else if (c == '-')
            {
                makeNextUpper = true;
            }
            else if (IsGreekLowercase(c))
            {
                makeNextUpper = false;
            }
            else if (!char.IsLetter(c))
            {
                makeNextUpper = false;
            }
            else
            {
                if (makeNextUpper)
                {
                    result += char.ToUpperInvariant(c);
                    makeNextUpper = false;
                }
                else
                {
                    result += c;
                }
            }
        }

        return result;
    }
    private static bool IsGreekLowercase(char c)
    {
        return c >= 'α' && c <= 'ω';
    }
}
