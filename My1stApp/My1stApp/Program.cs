// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// See on lisainfoks - kõigest kommentaar.
// Console.WriteLine("See ei ole kommentaar.");
// Rakendus vajab kasutaja sisestatud nime.
Console.WriteLine("Enter name!"); // output
// string userName;
// userName = Console.ReadLine();
string userName = Console.ReadLine(); // input

Console.WriteLine("Jello, " + userName + "!"); // output
// string interpolation - $ , {} - sulgude sees muutuja
Console.WriteLine($"Jello, {userName}!"); // output
