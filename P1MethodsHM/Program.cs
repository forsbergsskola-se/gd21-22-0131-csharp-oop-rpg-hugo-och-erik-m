static void Count(int from, int to)
{
    Console.WriteLine("counting from " + from + " to " + to + ": ");
    if (from < to)
    {
        for (int i = from; i <= to; i++) Console.WriteLine(i);
    }
    else
    {
        for (int i = from; i >= to; i--) Console.WriteLine(i);
    } 
}
Count(2,3);
Count(100,101);
Count(10,8);
Count(1,-1);
Count(1337,1337);