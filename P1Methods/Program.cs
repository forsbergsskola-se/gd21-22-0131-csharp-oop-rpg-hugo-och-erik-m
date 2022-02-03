static void Count(int from, int to)
{
    if (from < to)
    {
        Console.WriteLine($"Counting from {from} to {to}:");
        for (int i = from; from <= to; from++)
        {
            Console.WriteLine(from);
        }
    }
    else
    {
        Console.WriteLine($"Counting from {from} to {to}:");
        for (int i = from; from >= to; from--)
        { 
           Console.WriteLine(from);
        }   
    }  
}


Count(2, 3);
Count(100, 101);
Count(10, 8);
Count(1,-1);
Count(1337,1337);