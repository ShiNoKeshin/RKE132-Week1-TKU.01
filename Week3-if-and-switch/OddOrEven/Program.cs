using System.ComponentModel.Design;

Console.WriteLine("Sisesta number:");
int userNum = int.Parse(Console.ReadLine());

//if (userNum % 2 == 1)
//{ Console.WriteLine("Number on paaritu arv."); }
//else
//{ Console.WriteLine("Number in paarisarv."); }

int result = userNum % 2;
if (result != 0)
{ Console.WriteLine("Number on paaritu arv."); }
else
{ Console.WriteLine("Number in paarisarv."); }