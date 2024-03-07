int nylon = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int thinner = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

double total = (nylon + 2) * 1.5 + paint * 1.1 * 14.5 + thinner * 5 + 0.4;
double workPayment = hours * total * 0.3;

Console.WriteLine(total + workPayment);