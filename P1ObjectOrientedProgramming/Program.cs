string[] Names = new String [3];

 for(int i = 0; i < Names.Length; i++)
 {
  Console.WriteLine("Give a name.");
  Names[i] = Console.ReadLine();
 }

Console.WriteLine(Names[0]+","+Names[1]+","+Names[2]);