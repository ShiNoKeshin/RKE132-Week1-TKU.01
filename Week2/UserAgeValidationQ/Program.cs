// Rakendus küsib kasutaja vanust. Kui kasutaja vanus on väiksem kui 13, siis konsool kuvab"Oled liiga noor."
// Kui vanen, siis "Tervetuloa rakendusse."

Console.WriteLine("Enter age");
int userAge = int.Parse(Console.ReadLine());
if (userAge <= 13)
{ Console.WriteLine("Oled liiga noor."); }
else
{ Console.WriteLine("Tervetuloa rekendusse!"); }
