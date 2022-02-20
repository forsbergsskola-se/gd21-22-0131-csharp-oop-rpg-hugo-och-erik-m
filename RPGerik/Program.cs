static class Program
{
    static void Main()
    {
        Unit goblin = new Unit("Goblin", 123);
        Unit hobgoblin = new Unit("HobGoblin", 456);
        Unit goblinpriest = new Unit("GoblinPriest", 789);
    }
}

public class Unit
{
    public string name;
    public int Id;
    public static int nextId;

    private int maxHealth;
    private int health;


    public Unit(string name, int maxHealth)
    {
        this.name = name;
        Id = nextId++;

        this.maxHealth = maxHealth;
        this.health = maxHealth;

        // Make sure, that this is the last line of the constructor:
        ReportStatus();
    }

    public void SetHealth(int newHealth)
    {
        health = Math.Clamp(newHealth, 0, maxHealth);
        ReportStatus();
    }

    public void ReportStatus()
    {  
        Console.WriteLine($"Unit #{Id}: {name} - {health}/{maxHealth} Health");
    }
}