static void CountUp(int to)
{
     for (int i = 0; i <= to; i++)
     {
          Console.WriteLine(i);
     }
 
}
static void CountDown(int from)
{
     for (int i = from; i > -1; i--)
     {
          Console.WriteLine(i);
     }
}
Console.WriteLine("counting from 0 to 1");
CountUp(1);
Console.WriteLine("counting from 1 to 0");
CountDown(1);
Console.WriteLine("counting from 0 to 2");
CountUp(2);
Console.WriteLine("counting from 2 to 0");
CountDown(2);
Console.WriteLine("counting from 0 to 3");
CountUp(3);
Console.WriteLine("counting from 3 to 0");
CountDown(3);