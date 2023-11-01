string[] beer = { "originaal", "premium", "alexander", "heineken" };
string[] fruit = new string[3];
fruit[0] = "apples";
fruit[1] = "banans";
fruit[2] = "pears";

//Console.WriteLine($"{fruit[0]}, {fruit[1]}, {fruit[2]}");

int fruitArrayLength = fruit.Length;
int beerArrayLength = beer.Length;

Console.WriteLine($"There are {fruitArrayLength} fruits in the list.");

for ( int i = 0; i < fruitArrayLength; i++ )
{
    Console.WriteLine(fruit[i]);
}

Console.WriteLine($"There are {beerArrayLength} beers in the list.");

//for (int i = 0; i < beerArrayLength; i++)
//{
//    Console.WriteLine(beer[i]);
//}

//foreach(string element in beer)
//{
//    Console.WriteLine(element);
//}

for (int i = 0; i < beerArrayLength; i++)
{
    beer[i] = beer[i].Replace(beer[i][0], char.ToUpper(beer[i][0]));
    Console.WriteLine(beer[i]);
}