static class Program  //Main program
{
    static void Main()
    {
        Unit leet = new Unit("Leet",1337);
        while (leet.IsAlive)
        {
            Console.WriteLine("How much damage do you want to deal to Leet?");
            leet.Damage(int.Parse(Console.ReadLine()));
        }
       

    }
}

public class Unit  //Class for units, whithin body is the constructor
{
    public string name;
    public int id;
    public static int nextId;

    public bool IsAlive
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
    
    public Unit(string _name, int maxHealth)  //Constructor start
    {
        name = _name;
        id = nextId;
        nextId++;
        this.maxHealth = maxHealth;
        this.health = maxHealth;
        ReportStatus(); //This is where constructor ends!
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

    public void Damage (int value)
    {
        Health -= value;
    }
    
    public void ReportStatus()
    {
        Console.WriteLine($"Unit #{id}: {name} - {health}/{maxHealth} Health");
    }
        
    
}