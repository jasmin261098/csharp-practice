public class Robot
{
    private string _name;
    private static HashSet<string> usedNames = new HashSet<string>();
    private static Random random = new Random();
    
    public string Name
    {
        get
        {
            if (_name == null) {
                _name = GenerateUniqueName();
                usedNames.Add(_name);
            }
            return _name;
        }
    }

    public void Reset()
    {
        if (_name != null) {
            usedNames.Remove(_name);
            _name = null;
        }
    }

    private string GenerateUniqueName() {
        string name;
        do {
            char firstLetter = (char)('A' + random.Next(26));
            char secondLetter = (char)('A' + random.Next(26));
            int digit1 = random.Next(10); //0-9
            int digit2 = random.Next(10);
            int digit3 = random.Next(10);

            name = $"{firstLetter}{secondLetter}{digit1}{digit2}{digit3}";
        } while (usedNames.Contains(name));

        return name;
    }
}