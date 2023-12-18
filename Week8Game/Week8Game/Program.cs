//string[] heroes = {"Luffy", "Goku", "Ichigo", "Saitama", "Neo" };
//string[] villains = {"Imu", "Frieza", "Aizen", "Orochi", "Agent Smith" };

string folderPath = @"C:\Users\SANTA\OneDrive\Dokumendid\Data\";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));
string[] weapons1 = { "Gomu Gomu gun", "MP5", "Katana", "Serious Punch", "SS mode" };
string[] weapons2 = { "a banana", "a rubber mallet", "a stick", "hopes and prayers" };

//Random rnd = new Random();
//int rndIndx = rnd.Next(0, heroes.Length);
string hero = GetRndValueFromArray(heroes);
string heroWeapon = GetRndValueFromArray(weapons1);
Console.WriteLine($"{hero} does things with the {heroWeapon}.");

//rndIndx = rnd.Next(0, villains.Length);
string villain = GetRndValueFromArray(villains);
string villainWeapon = GetRndValueFromArray(weapons2);
Console.WriteLine($"{villain} tries to kill him with {villainWeapon}");

static string GetRndValueFromArray(string[] SomeArray)
{
    Random rnd = new Random();
    int rndIndx = rnd.Next(0, SomeArray.Length);
    string rndStringFromArray = SomeArray[rndIndx];
    return rndStringFromArray;
}
