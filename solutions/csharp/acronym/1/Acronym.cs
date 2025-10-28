using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string cleaned = Regex.Replace(phrase, @"[^A-Za-z0-9\s-]", "");
        cleaned = Regex.Replace(cleaned, "-", " ");
        string acronym = string.Concat(
            cleaned
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(word => char.ToUpper(word[0]))
        );
        return acronym;
    }
}