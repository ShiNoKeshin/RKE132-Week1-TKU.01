int sum = 0;

for (int i = 1;  i < 11; i++)
{
    Console.WriteLine($"i = {i}");
    sum = sum + i;
    Console.WriteLine($"current total : {sum}");
}
Console.WriteLine($"final sum: {sum}");