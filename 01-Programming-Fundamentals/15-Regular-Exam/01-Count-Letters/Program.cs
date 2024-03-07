string text = Console.ReadLine();
int upperCase = 0;
int lowerCase = 0;
int singleSpaces = 0;

for  (int i = 0; i < text.Length; i++)
{
    if (char.IsUpper(text[i]))
    {
        upperCase++;
    } else if (char.IsLower(text[i]))
    {
        lowerCase++;
    } else if (char.IsWhiteSpace(text[i])) {
        singleSpaces++;
    }
}

Console.WriteLine(upperCase);
Console.WriteLine(lowerCase);
Console.WriteLine(singleSpaces);