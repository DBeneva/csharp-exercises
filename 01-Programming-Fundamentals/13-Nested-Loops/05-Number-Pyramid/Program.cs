int n = int.Parse(Console.ReadLine());
int currentNumber = 1;
int numbersPerRow = 1;

while (currentNumber <= n)
{
    for (int i = 1; i <= numbersPerRow; i++)
    {
        Console.Write($"{currentNumber} ");
        currentNumber++;

        if (currentNumber > n)
        {
            break;
        }
    }

    Console.WriteLine("");
    numbersPerRow++;
}