int[] nums = new int[10];
Random rnd= new Random();

int sum = 0;

for (int i = 0; i < nums.Length; i++)
{
    nums[i] = rnd.Next(1, nums.Length + 1);
    sum += nums[i];
}

foreach(int num in nums)
{
    Console.WriteLine(num);
}

Console.WriteLine($"Total: {sum}");