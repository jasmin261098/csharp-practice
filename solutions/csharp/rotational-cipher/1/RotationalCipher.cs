using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        StringBuilder cipher = new StringBuilder();
        
        foreach (char c in text) {
            if (char.IsLower(c)) {
                char shifted = (char)((c - 'a' + shiftKey) % 26 + 'a');
                cipher.Append(shifted);
            } else if (char.IsUpper(c)) {
                char shifted = (char)((c - 'A' + shiftKey) % 26 + 'A');
                cipher.Append(shifted);
            } else {
                cipher.Append(c);
            }
        }
        return cipher.ToString();
    }
}