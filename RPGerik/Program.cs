static class Program
{
    static void Main()
    {
        Unit leet = new Unit("Leet", 1337);

        while(leet.isAlive)
        {
            Console.WriteLine("How much damage do you want to deal to Leet?");
            leet.Damage(int.Parse(Console.ReadLine()));
        }
    }
}

public class Unit
{
    public string Name { get; }
    public int Id;
    public static int nextId;

    public bool isAlive
    {
        get
        {
            if (health > 0)
                return true;
            else
                return false;

        }
    }

    private int maxHealth;
    private int health;


    public Unit(string name, int maxHealth)
    {
        Name = name;
        Id = nextId++;

        this.maxHealth = maxHealth;
        this.health = maxHealth;

        // Make sure, that this is the last line of the constructor:
        ReportStatus();
    }

    public int Health
    {
        private set
        {
            health = Math.Clamp(value, 0, maxHealth);
            ReportStatus();
        }
        get { return health; }

    }

    public void Damage(int value)
    {
        Health -= value;
        
    }


    public void ReportStatus()
    {  
        Console.WriteLine($"Unit #{Id}: {Name} - {health}/{maxHealth} Health");
    }
}