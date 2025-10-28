public static class Bob
{
    public static string Response(string statement)
    {
        bool isYelling = statement.Any(char.IsLetter) && statement.Where(char.IsLetter).All(char.IsUpper);
        
        if (string.IsNullOrWhiteSpace(statement)) {
            return "Fine. Be that way!";
        } else if (statement.Contains("?") && isYelling) {
            return "Calm down, I know what I'm doing!";
        } else if (isYelling) {
            return "Whoa, chill out!";
        } else if (statement.EndsWith("?")) {
            return "Sure.";
        } else if (statement.Contains("?") && statement.EndsWith(" ")) {
            return "Sure.";
        } else {
            return "Whatever.";
        }
    }
}