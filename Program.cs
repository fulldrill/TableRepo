// See https://aka.ms/new-console-template for more information
Console.WriteLine("We Welcome you in C#");
int num = 12;
System.Console.WriteLine($"*Table of {num}*");
for (int i = 1; i <= 10; i++)
{
    System.Console.WriteLine($"{num}*{i}=\t {num * i}");
}

System.Console.WriteLine("Printing Numbers from 1 to 100");
for (int i = 1; i <= 100; i++)
{ 
    System.Console.Write(i+"\t");
}

System.Console.WriteLine("Printing Numbers from 1 to 800 divisible by 8");
for (int i = 1; i <=800; i++)
{
    if (i % 8 == 0)
    { System.Console.Write(i + "\t"); }
}
