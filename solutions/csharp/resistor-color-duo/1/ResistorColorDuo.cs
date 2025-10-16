public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        var colorMap = new Dictionary<string, int> {
            ["black"] = 0,
            ["brown"] = 1,
            ["red"] = 2,
            ["orange"] = 3,
            ["yellow"] = 4,
            ["green"] = 5,
            ["blue"] = 6,
            ["violet"] = 7,
            ["grey"] = 8,
            ["white"] = 9
        };

        int first = colorMap[colors[0]];
        int second = colorMap[colors[1]];

        int result = first * 10 + second;

        return result;
    }
}
