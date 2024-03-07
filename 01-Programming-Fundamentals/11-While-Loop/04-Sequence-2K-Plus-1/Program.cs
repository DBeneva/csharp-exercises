int n = int.Parse(Console.ReadLine());
int sum = 1;

Console.WriteLine(sum);

while  (sum * 2 + 1 <= n)
{
    sum = sum * 2 + 1;
    Console.WriteLine(sum);
}