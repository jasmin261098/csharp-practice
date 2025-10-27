public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        string lower = word.ToLower();

        HashSet<char> seen = new HashSet<char>();

        foreach (char c in lower) {
            if (c == ' ' || c == '-')
                continue;
            if (!seen.Add(c)) {
                return false;
            }
        }
        return true;
    }
}
