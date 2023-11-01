string[] snacks = { "maccas", "pizza", "cheeeeese", "wine", "sushi" };

Random rnd = new Random();

int rndIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonight we will feast on {snacks[rndIndex]}.");