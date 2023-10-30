//Console.WriteLine("Tere, Tony!");

Console.WriteLine("Select your gender(m/f).");
char userGender = char.Parse(Console.ReadLine());
Console.WriteLine("Please insert your name.");
string userName = Console.ReadLine();
if (userGender == 'm')
{
    Console.WriteLine($"Good morrow dear Sir {userName}.");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Hello, Ms. {userName}");
}
else
{
    Console.WriteLine($"Welcome {userName}.");
}
//Console.WriteLine($"Welcome, {userGender}.");
