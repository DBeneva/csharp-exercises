int n = int.Parse(Console.ReadLine());
int sum = 0;
int divisor = 1;

while (n > divisor)
{
    sum += n / divisor % 10;
    divisor *= 10;
}

Console.WriteLine(sum);