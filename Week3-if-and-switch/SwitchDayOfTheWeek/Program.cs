int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);
switch (weekDay)
{
    case 0:
        Console.WriteLine("On pühapäev.");
        break;
    case 1:
        Console.WriteLine("Blue Monday.");
        break;
    case 2:
        Console.WriteLine("It's Chewsday, init.");
        break;
    case 3:
        Console.WriteLine("Nädala selgroog on murtud.");
        break;
    case 4:
        Console.WriteLine("Its the thurd day, thursday.");
        break;
    case 5:
        Console.WriteLine("Iiiits Friiidaaaay, friiidaay, friiiidaaaaay!");
        break;
    case 6:
        Console.WriteLine("Rest on the saturday.");
        break;
    default:
        Console.WriteLine("Unexpected error. Please reset yourself.");
        break;
}
Console.WriteLine("Have a day.");