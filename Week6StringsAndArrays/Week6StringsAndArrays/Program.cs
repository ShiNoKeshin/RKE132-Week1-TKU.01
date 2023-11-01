string hello = " hellow, world! You exist. ";


//string trimmedStr = hello.Trim();
hello = hello.Trim();

int stringLength = hello.Length;
int wordCounter = 1;

//hello = hello.Replace(hello[0], 'H');
hello = hello.Replace(hello[0], char.ToUpper(hello[0]));
//char firstLetter = hello[0];

for (int i = 0; i < hello.Length; i++)
{
    //if (hello[i] == ' ')
    //{  
    //    wordCounter++; 
    //}
    if (char.IsWhiteSpace(hello[i]))
    { 
        wordCounter++;
    }
}

Console.WriteLine($"Say hello: " + hello);
Console.WriteLine($"How many words are in {hello}: {wordCounter} ");
