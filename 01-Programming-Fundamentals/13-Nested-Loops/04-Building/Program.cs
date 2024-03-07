int floors = int.Parse(Console.ReadLine());
int estates = int.Parse(Console.ReadLine());

for (int i = floors; i >= 1; i--)
{
    char type;

    if (i == floors)
    {
        type = 'L';
    } else if (i % 2 == 1)
    {
        type = 'A';
    } else
    {
        type = 'O';
    }

    for (int j = 0; j < estates; j++)
    {
        Console.Write($"{type}{i}{j} ");
    }

    Console.WriteLine("");
}