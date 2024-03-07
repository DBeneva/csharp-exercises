int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());

double aquariumVolume = length * width * height;
double volumeInLiters = aquariumVolume / 1000;
double requiredLiters = volumeInLiters * (1 - percentage / 100);

Console.WriteLine($"{requiredLiters:F2}");