public class Player
{
    public int RollDie()
    {
        var dice = new Random();
        return dice.Next(1,19);
    }

    public double GenerateSpellStrength()
    {
        var spellStrength = new Random();
        return spellStrength.NextDouble()*100;
    }
}
