Console.WriteLine("Name the god:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog stillMyDog = new Dog("Chester");

Console.WriteLine($"{myDog.Name} the dog name.");
Console.WriteLine($"{stillMyDog.Name} is also dog.");

myDog.Rename("Douggie");

while (myDog.LevelOfWag != 5)
{
    myDog.Bork();
}

myDog.WagBoy();

while (myDog.LevelOfBork != 5)
{
    myDog.WagBoy();
}

myDog.Bork();

class Dog
{
    private string _name;
    private int _levelOfWag;
    private int _levelOfBork;

    //constructor
    public Dog(string name) //name - name the dog
    {
        _name = name;
        _levelOfWag = 0;
    }

    //getter
    public string Name
    { get 
        { return _name; } 
    }

    public int LevelOfWag
    {
        get { return _levelOfWag; }
    }

    public int LevelOfBork
    {
        get { return _levelOfBork; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"An dog has been renamed to {newName}.");
    }

    public void Bork()
    {
        Console.WriteLine("Woofer bork");
        _levelOfWag++;
    }

    public void WagBoy()
    {
        Console.WriteLine("Waggle wiggle-");
        _levelOfBork++;
    }

}
