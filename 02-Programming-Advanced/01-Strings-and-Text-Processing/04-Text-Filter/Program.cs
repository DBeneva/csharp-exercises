string[] bannedWords = Console.ReadLine().Split(", ");
string text = Console.ReadLine();
string outputLine = text;

foreach (string bannedWord in bannedWords)
{
    string placeholder = new string('*', bannedWord.Length);

    while (outputLine.Contains(bannedWord))
    {
        outputLine = outputLine.Replace(bannedWord, placeholder);
    }
}

Console.WriteLine(outputLine);