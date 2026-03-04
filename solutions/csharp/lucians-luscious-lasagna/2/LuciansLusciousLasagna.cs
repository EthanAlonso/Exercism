class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven () => 40;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven (int x)
    {
        return 40-x;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes (int y)
    {
        return y*2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes (int y, int x)
    {
        return PreparationTimeInMinutes(y)+x;
    }
}

