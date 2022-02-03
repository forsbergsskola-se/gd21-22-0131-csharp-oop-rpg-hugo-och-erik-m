static void CountUp()
{
     for (int i = 0; i < 6; i++)
     {
          Console.WriteLine(i);
     }
 
}
static void CountDown()
{
     for (int i = 5; i > -1; i--)
     {
          Console.WriteLine(i);
     }
}
Console.WriteLine("counting from 0 to 5");
CountUp();
Console.WriteLine("counting from 5 to 0");
CountDown();
Console.WriteLine("counting from 0 to 5");
CountUp();
Console.WriteLine("counting from 5 to 0");
CountDown();