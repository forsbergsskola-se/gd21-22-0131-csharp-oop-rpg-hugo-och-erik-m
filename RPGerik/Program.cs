static class Program
{
    static void Main()
    {
        Unit leet = new Unit("Leet", 1337);

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("What do you want Leet's health to be");
            leet.Health = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("i want to increase his health by 50:");
        leet.Health += 50;
        //Unit hobgoblin = new Unit("HobGoblin", 456);
        //Unit goblinpriest = new Unit("GoblinPriest", 789);
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

    public int Health
    {
        set
        {
            health = Math.Clamp(value, 0, maxHealth);
            ReportStatus();
        }
        get
        {
            return health;
        }
    }


    public void ReportStatus()
    {  
        Console.WriteLine($"Unit #{Id}: {name} - {health}/{maxHealth} Health");
    }
}