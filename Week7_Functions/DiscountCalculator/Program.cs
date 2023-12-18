// < 10 - 1%
// 10 <= x < 20 - 5%
// >= 20 - 10%
Console.WriteLine("Enter total:");

int userInput = Int32.Parse(Console.ReadLine());
double discount = CalculateDiscount(userInput);

Console.WriteLine($"Discount is {discount}%");

double newTotal = CalcNewTotal(userInput, discount);

Console.WriteLine($"New total is: {newTotal}");
static double CalculateDiscount(int total)
{
    if (total < 10) return 1;
    else if (total < 20 && total >= 10) return 5;
    else return 10;
}

static double CalcNewTotal(double total, double discount)
{
    double result = total * ((100 - discount) / 100);
    return result;
}