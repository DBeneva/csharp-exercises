using System.Reflection.Metadata;

string firstString = Console.ReadLine();
string secondString = Console.ReadLine();

while (secondString.Contains(firstString))
{
    // secondString = secondString.Replace(firstString, "");

    string before = secondString.Substring(0, secondString.IndexOf(firstString));
    string after = secondString.Substring(secondString.IndexOf(firstString) + firstString.Length);

    secondString = before + after;
}

Console.WriteLine(secondString);