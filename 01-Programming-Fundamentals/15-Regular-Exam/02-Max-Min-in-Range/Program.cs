string inputLine = Console.ReadLine();
string[] numbers = inputLine.Split(" ");
int[] arr = numbers.Select(int.Parse).ToArray();
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
List<int> list = new List<int>();

for  (int i = n; i <= m; i++)
{
    list.Add(arr[i]);
}

list.Sort();
int max = list[0];
int min = list[list.Count-1];

Console.WriteLine(max + min);