Console.WriteLine("You in or out?");
string userChoice = Console.ReadLine();

if (userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}

static void PrintHello() //function
{
    Console.WriteLine("Hello, world?");
}

static void PrintGoodBye()
{
    Console.WriteLine("Bye.");
}

