string folderPath = @"C:\Users\SANTA\OneDrive\Dokumendid\Data";
string fileName = "shopping.txt";
string filePath = Path.Combine(folderPath, fileName);
List<string> myShoppingList = new List<string>();

if (File.Exists(filePath))
{
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}
else
{
    File.Create(filePath).Close();
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}

ShowItemsFromList(myShoppingList);
static List<string> GetItemsFromUser()
{
    List<string> userList = new List<string>();
    while (true)
    {
        Console.WriteLine("Add your stuff (add) or exit (exit)");
        string userChoice = Console.ReadLine();
        if (userChoice == "add")
        {
            Console.WriteLine("Enter the thing:");
            string userItem = Console.ReadLine();
            userList.Add(userItem);
        }
        else if (userChoice == "exit")
        {
            Console.WriteLine("You have completer your list of stuff.");
            break;
        }
        else
        {
            Console.WriteLine("Incorrect input.");
        }
    }
    return userList;
}

static void ShowItemsFromList(List<string> someList)
{
    Console.Clear();
    int listLength = someList.Count;
    Console.WriteLine($"Your list has {listLength} item(s).");
    int i = 1;
    foreach (string item in someList)
    {
        Console.WriteLine($"{i}. {item}");
        i++;
    }
}