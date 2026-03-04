class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven () => 40;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven (int x) => 40-x;

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes (int y) =>         y*2;

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes (int y, int x) => PreparationTimeInMinutes(y)+x;
}

