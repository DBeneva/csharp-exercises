string text = Console.ReadLine();
string digits = "";
string letters = "";
string others = "";

foreach (char c in text)
{
    if (char.IsDigit(c))
    {
        digits += c;
    }
    else if (char.IsLetter(c))
    {
        letters += c;
    }
    else
    {
        others += c;
    }
}

Console.WriteLine(digits);
Console.WriteLine(letters);
Console.WriteLine(others);