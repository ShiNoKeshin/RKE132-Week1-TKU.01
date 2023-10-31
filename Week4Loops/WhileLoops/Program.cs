// while loop - käitab tsüklit tingimuse täitumiseni
Random rnd = new Random();
int randomNum;
bool loopActive = true;
while (loopActive)
{
    randomNum = rnd.Next(1,4);
    Console.WriteLine("Guess the number(1-3):");
    int userNumber = Int32.Parse(Console.ReadLine());
    if (userNumber == randomNum)
    {
        Console.WriteLine("Nice guess.");
        //loopActive = false;
        break;
    }
    else 
    {
        Console.WriteLine("Nope.");
    }
}
Console.WriteLine("Have a day.");
