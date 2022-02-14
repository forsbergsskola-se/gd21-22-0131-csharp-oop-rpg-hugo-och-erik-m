static class Program  //Main program
{
    static void Main()
    {
        Unit Zombie = new Unit("Zombie",200);
        Unit Skeleton = new Unit("Skeleton",300);
        Unit Necromancer = new Unit("Necromancer",400);

    }
}

public class Unit  //Class for units, whithin body is the constructor
{
    public string name;
    public int id;
    public static int nextId;
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

    public void SetHealth(int newHealth)
    {

        health = Math.Clamp(newHealth, 0, maxHealth);
        ReportStatus();

    }
    
    
    
    public void ReportStatus()
    {
        Console.WriteLine($"Unit #{id}: {name} - {health}/{maxHealth} Health");
    }
        
    
}