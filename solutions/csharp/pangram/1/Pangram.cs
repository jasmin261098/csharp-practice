public static class Pangram
{
    public static bool IsPangram(string input)
    {
        string lower = input.ToLower();

        HashSet<char> seen = new HashSet<char>();

        foreach (char c in lower) {
            if (char.IsLetter(c)) {
                seen.Add(c);
            }
        }

        return seen.Count == 26;
    }
}
