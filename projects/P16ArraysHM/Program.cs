int[] array = new int[10000]; // array size 10k
var randomGenerator = new Random(); // "dice" creates random number

Console.WriteLine("I will roll 10.000 numbers between 0 and 10:");
for (int i = 0; i < 10000; i++)  // makes this loop go 10k times
{   
    int randomInt = randomGenerator.Next(0, 11); // creates random number 10k times and places in 10k different places in array
    array[i] = randomInt;
}

for (int i = 0; i < 11; i++)  // counts from 0-10
{
    int occurrences = array.Count(x => x == i);  // "magic" counts the occurence of given number inside array
    
    Console.WriteLine("i rolled "+i+" a total of "+occurrences+" times"); // prints text so user understands what each number represents
    
}
