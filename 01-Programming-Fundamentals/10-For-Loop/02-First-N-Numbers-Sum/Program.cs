int n = int.Parse(Console.ReadLine());

int sum = 1;
string outputLine = "1";

for (int i = 2; i <= n; i++)
{
    sum += i;
    outputLine += "+" + i;
}

Console.WriteLine(outputLine + "=" + sum);