int annualFee = int.Parse(Console.ReadLine());

double sneakers = annualFee * 0.6;
double clothing = sneakers * 0.8;
double ball = clothing / 4;
double accessories = ball / 5;

Console.WriteLine(annualFee + sneakers + clothing + ball + accessories);