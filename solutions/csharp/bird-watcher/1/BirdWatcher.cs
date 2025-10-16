class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] lastWeek = {0, 2, 5, 3, 7, 8, 4};
        return lastWeek;
    }

    public int Today()
    {
        int n = birdsPerDay.Length;
        int birdsToday = birdsPerDay[n - 1];
        return birdsToday;
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        for (int i = 0; i < birdsPerDay.Length; i++) {
            if (birdsPerDay[i] == 0) {
                return true;
            } 
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sum = 0;
        for (int i = 0; i < numberOfDays && i < birdsPerDay.Length; i++) {
            sum += birdsPerDay[i];
        }
        return sum;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        for (int i = 0; i < birdsPerDay.Length; i++) {
            if (birdsPerDay[i] >= 5) {
                busyDays++;
            }
        }
        return busyDays;
    }
}
