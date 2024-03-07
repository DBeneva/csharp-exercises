int dogFoodPackages = int.Parse(Console.ReadLine());
int catFoodPackages = int.Parse(Console.ReadLine());
double expenses = dogFoodPackages * 2.5 + catFoodPackages * 4;

Console.WriteLine($"{expenses:F2} lv.");