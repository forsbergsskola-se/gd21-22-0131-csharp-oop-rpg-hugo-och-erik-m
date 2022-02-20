static class Program
{
    static void Main()
    {
        Unit goblin = new Unit("Goblin");
        Unit hobgoblin = new Unit("HobGoblin");
        Unit goblinpriest = new Unit("GoblinPriest");
    }
}

public class Unit
{
    public string name;
    public int Id;
    public static int nextId;


    public Unit(string name)
    {
        this.name = name;
        Id = nextId++;
        
        // Make sure, that this is the last line of the constructor:
        ReportStatus();
    }

    public void ReportStatus()
    {  
        Console.WriteLine($"Unit #{Id}: {name}");
    }
}