public static class Languages
{
    public static List<string> NewList()
    {
        var list = new List<string>();
        return list;
    }

    public static List<string> GetExistingLanguages()
    {
        var list = NewList();
        list.Add("C#");
        list.Add("Clojure");
        list.Add("Elm");
        return list;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        int count = 0;
        for (int i = 0; i < languages.Count; i++) {
            count++;
        }
        return count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
            if (languages.Contains(language)) {
                return true;
            } else {
                return false;
            }
    }

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        if (languages.Count == 0) {
            return false;
        }
        
        if (languages[0] == "C#") {
            return true;
        } else if (languages[1] == "C#" && (languages.Count == 2 || languages.Count == 3)) {
            return true;
        } else {
            return false;
        }
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        for (int i = 0; i < languages.Count - 1; i++) {
            string element = languages[i];
            for (int j = i + 1; j < languages.Count; j++) {
                if (languages[j] == element) {
                    return false;
                }
            }
        }
        return true;
    }
}
