double deposit = double.Parse(Console.ReadLine());
int depositTerm = int.Parse(Console.ReadLine());
double annualInterest = double.Parse(Console.ReadLine());

Console.WriteLine(deposit + depositTerm * (deposit * annualInterest / 100) / 12);