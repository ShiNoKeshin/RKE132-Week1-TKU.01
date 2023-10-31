// temp <= 0 - freezing
// temp > 0 and temp <= 10 - cold
// temp > 10 and temp <= 14 - chilly
// temp > 14 and temp <= 20 - warm
// temp > 20 and temp <= 30 - hot
// temp > 30 - hell

Console.WriteLine("Enter temperature(C):");
int temp = Int32.Parse(Console.ReadLine());

if (temp <= 0)
{
    Console.WriteLine("Its Freezing.");
}
else if (temp > 0 && temp <= 10 )
{
    Console.WriteLine("Its Cold.");
}
else if (temp > 10 && temp <= 14)
{
    Console.WriteLine("Its Chilly.");
}
else if (temp > 14 && temp <= 20)
{
    Console.WriteLine("Its Warm.");
}
else if (temp > 20 && temp <= 30)
{
    Console.WriteLine("Its Hot.");
}
else if (temp > 30)
{
    Console.WriteLine("Its hot as hell.");
}
else
{
    Console.WriteLine("Something is wrong with the weather.");
}
Console.WriteLine("Have a day.");