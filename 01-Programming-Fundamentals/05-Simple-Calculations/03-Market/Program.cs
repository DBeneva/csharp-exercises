double tomatoPrice = double.Parse(Console.ReadLine());
double tomatoQty = double.Parse(Console.ReadLine());
double cucumberPrice = double.Parse(Console.ReadLine());
double cucumberQty = double.Parse(Console.ReadLine());

Console.WriteLine($"{(tomatoPrice * tomatoQty + cucumberPrice * cucumberQty):F2}");
