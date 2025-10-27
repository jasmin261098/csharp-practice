using System.Text.RegularExpressions;
using System.Globalization;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        if (string.IsNullOrEmpty(identifier))
            return "";

        // Step 1: Replace spaces with underscores
        string result = identifier.Replace(" ", "_");

        // Step 2: Replace control characters with "CTRL"
        result = Regex.Replace(result, @"\p{Cc}", "CTRL");

        // Step 3: Convert kebab-case to camelCase (uppercase any letter after '-')
        result = Regex.Replace(result, @"-(\p{L})", m => m.Groups[1].Value.ToUpper(CultureInfo.InvariantCulture));

        // Step 4: Remove any character that is not a letter or underscore
        result = Regex.Replace(result, @"[^\p{L}_]", "");

        // Step 5: Remove lowercase Greek letters (α–ω)
        result = Regex.Replace(result, "[\u03B1-\u03C9]", "");

        return result;
    }
}
