public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        switch (shirtNum) {
            case 1:
                return "goalie";
            case 2: 
                return "left back";
            case 3:
            case 4:
                return "center back";
            case 5:
                return "right back";
            case 6:
            case 7:
            case 8:
                return "midfielder";
            case 9:
                return "left wing";
            case 10:
                return "striker";
            case 11:
                return "right wing";
            default:
                return "UNKNOWN";
        }
    }

    public static string AnalyzeOffField(object report)
    {
        switch (report) {
            case int i:
                return $"There are {i} supporters at the match.";
            case string s:
                return $"{s}";
            case Injury inj:
                return $"Oh no! {inj.GetDescription()} Medics are on the field.";
            case Foul foul:
                return foul.GetDescription();
            case Incident inc:
                return inc.GetDescription();
            case Manager m when m.Club == null:
                return m.Name;
            case Manager m:
                return $"{m.Name} ({m.Club})";
            default:
                return "";
        }
    }
}
