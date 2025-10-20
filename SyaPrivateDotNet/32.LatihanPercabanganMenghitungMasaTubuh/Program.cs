// See https://aka.ms/new-console-template for more information

Console.Write("Input berat badan: ");
double beratBadan = Convert.ToDouble(Console.ReadLine());

Console.Write("Input Tinggi badan: ");
double tinggiBadan = Convert.ToDouble(Console.ReadLine());

double imt = beratBadan / (tinggiBadan * tinggiBadan);

Console.WriteLine($"\nIMT Anda: {imt:F2}");

if (imt < 18.5)
{
    Console.WriteLine("kurus");
} 
else if (imt >= 18.5 && imt <= 24.9)
{
    Console.WriteLine("normal");
}
else if (imt >= 25 &&  imt <= 29.9)
{
    Console.WriteLine("kelebihan");
} 
else if (imt >= 30)
{
    Console.WriteLine("obesitas");
}