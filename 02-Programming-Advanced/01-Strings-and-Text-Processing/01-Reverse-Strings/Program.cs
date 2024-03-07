using System.Threading.Tasks.Dataflow;

string text = Console.ReadLine();

while (text != "end")
{
    string reversedText = string.Join("", text.Reverse().ToArray());
        
    // string reversedText = "";

    // for (int i = text.Length - 1; i >= 0; i--)
    // {
    //     reversedText += text[i];
    // }

    Console.WriteLine($"{text} = {reversedText}");
    text = Console.ReadLine();
}