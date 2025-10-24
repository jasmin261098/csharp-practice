public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] output = new char[input.Length];
        int forwardIndex = 0;

        for (int backwardIndex = input.Length -1; backwardIndex >= 0; backwardIndex--) {
            output[forwardIndex] = input[backwardIndex];
            forwardIndex++;
        }
        return new string(output);
    }
}