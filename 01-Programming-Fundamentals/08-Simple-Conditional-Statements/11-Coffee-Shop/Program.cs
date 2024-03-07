string drink = Console.ReadLine();
string extra = Console.ReadLine();

if (drink == "coffee")
{
    if (extra == "sugar")
    {
        Console.WriteLine("Final price: $1.40");
    }
    else
    {
        Console.WriteLine("Final price: $1.00");
    }
}
else if (drink == "tea")
{
    if (extra == "sugar")
    {
        Console.WriteLine("Final price: $1.00");
    }
    else
    {
        Console.WriteLine("Final price: $0.60");
    }
}
