string movieType = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int seatsPerRow = int.Parse(Console.ReadLine());

switch (movieType)
{
    case "Premiere":
        Console.WriteLine($"{(rows * seatsPerRow * 12):F2}");
        break;
    case "Normal":
        Console.WriteLine($"{(rows * seatsPerRow * 7.5):F2}");
        break;
    case "Discount":
        Console.WriteLine($"{(rows * seatsPerRow * 5):F2}");
        break;
}
