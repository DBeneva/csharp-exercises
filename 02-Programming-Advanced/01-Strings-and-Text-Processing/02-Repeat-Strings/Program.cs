using System.Diagnostics.Tracing;

string[] words = Console.ReadLine().Split(" ");
string outputLine = "";

foreach (string word in words)
{
    for (int j = 0; j < word.Length; j++)
    {
        outputLine += word;
    }
}

Console.WriteLine(outputLine);