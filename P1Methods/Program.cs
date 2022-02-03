CountUp();
static void CountUp()
{
    Console.WriteLine("Counting from 0 to 5:");
    for (int i = 0; i <= 5; i++)
    {
        Console.WriteLine(i);
    }
    
}


CountDown();
static void CountDown()
{
    Console.WriteLine("Counting from 5 to 0:");
    for (int i = 5; i >= 0; i--)
    {
        Console.WriteLine(i);
    }
    
}
CountUp();
CountDown();