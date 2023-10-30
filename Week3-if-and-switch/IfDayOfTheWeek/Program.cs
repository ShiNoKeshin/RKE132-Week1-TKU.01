int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

//Console.WriteLine(weekDay);

if (weekDay == 0)
{ Console.WriteLine("On püüüühaaapäääeeeeeeeev!"); }
else if (weekDay == 1)
{ Console.WriteLine("Dear God, its monday:("); }
else if (weekDay == 2)
{ Console.WriteLine("On teisipäev."); }
else if (weekDay == 3)
{ Console.WriteLine("Humpday ;)"); }
else if (weekDay == 4)
{ Console.WriteLine("On neljapäev, üks on jäänud."); }
else if (weekDay == 5)
{ Console.WriteLine("Iiiits Friiidaaaay, friiidaay, friiiidaaaaay!"); }
else
{ Console.WriteLine("Puhka, on laupäev."); }
Console.WriteLine("Have a day!");