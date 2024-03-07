string product = Console.ReadLine();
string day = Console.ReadLine();

if (product == "Banana" && day == "Weekday")
{
    Console.WriteLine("2.50");
}
else if (product == "Banana" && day == "Weekend")
{
    Console.WriteLine("2.70");
}
else if (product == "Apple" && day == "Weekday")
{
    Console.WriteLine("1.30");
}
else if (product == "Apple" && day == "Weekend")
{
    Console.WriteLine("1.60");
}
else if (product == "Kiwi" && day == "Weekday")
{
    Console.WriteLine("2.20");
}
else if (product == "Kiwi" && day == "Weekend")
{
    Console.WriteLine("3.00");
}