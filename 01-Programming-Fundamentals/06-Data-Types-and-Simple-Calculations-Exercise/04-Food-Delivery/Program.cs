int chickens = int.Parse(Console.ReadLine());
int fishMenus = int.Parse(Console.ReadLine());
int vegeteriianMenus = int.Parse(Console.ReadLine());

double bill = chickens * 10.35 + fishMenus * 12.4 + vegeteriianMenus * 8.15;
double desert = bill * 0.2;
double total = bill + desert;

Console.WriteLine(total + 2.5);