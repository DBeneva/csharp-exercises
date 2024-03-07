string figure = Console.ReadLine();

if (figure == "square")
{
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine($"{(a * a):F2}");
}
else if (figure == "rectangle")
{
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine($"{(a * b):F2}");
}
else if (figure == "circle")
{
    double r = double.Parse(Console.ReadLine());
    Console.WriteLine($"{(Math.PI * r * r):F2}");
}