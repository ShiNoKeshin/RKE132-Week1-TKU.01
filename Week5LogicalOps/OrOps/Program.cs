﻿// math >= 90 or chem >= 90 or bio >= 90

int math, bio, chem;
Console.WriteLine("Sisesta matemaatikaeksami tulemus:");
math = Int32.Parse(Console.ReadLine());
Console.WriteLine("Sisesta bioloogiaeksami tulemus:");
bio = Int32.Parse(Console.ReadLine());
Console.WriteLine("Sisesta keemiaeksami tulemus:");
chem = Int32.Parse(Console.ReadLine());

if ((chem >= 90 && bio >= 90) || (math >= 90 && bio >= 90) || (math >= 90 && chem >= 90))
{
    Console.WriteLine("Oled ülikooli vastuvõetav.");
}
else
{
    Console.WriteLine("Su tulemused ei vasta vastuvõtutingimustele.");
}
Console.WriteLine("Have a day.");