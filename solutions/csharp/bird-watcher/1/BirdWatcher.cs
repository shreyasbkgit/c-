using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        // The exercise specifies this fixed sample for "last week"
        return new[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        // Return today's (last element) count
        return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        // Increment today's count in-place
        birdsPerDay[birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        // Any day with zero birds?
        foreach (var n in birdsPerDay)
            if (n == 0) return true;
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        // Sum the first N days (cap N to array length)
        int limit = Math.Min(numberOfDays, birdsPerDay.Length);
        int sum = 0;
        for (int i = 0; i < limit; i++) sum += birdsPerDay[i];
        return sum;
    }

    public int BusyDays()
    {
        // "Busy" defined as >= 5 birds
        int count = 0;
        foreach (var n in birdsPerDay)
            if (n >= 5) count++;
        return count;
    }
}
