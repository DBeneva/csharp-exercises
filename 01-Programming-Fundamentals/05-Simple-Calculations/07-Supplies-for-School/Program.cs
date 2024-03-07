int penPackages = int.Parse(Console.ReadLine());
int markerPackets = int.Parse(Console.ReadLine());
int boardCleanerLiters = int.Parse(Console.ReadLine());
int discountPercentage = int.Parse(Console.ReadLine());

double neededAmount = penPackages * 5.8 + markerPackets * 7.2 + boardCleanerLiters * 1.2;
double amountAfterDiscount = neededAmount - neededAmount * discountPercentage / 100;

Console.WriteLine(amountAfterDiscount);