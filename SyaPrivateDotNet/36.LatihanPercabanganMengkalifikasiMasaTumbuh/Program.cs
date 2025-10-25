// See https://aka.ms/new-console-template for more information
Console.Write("Input Usia 1-17thn: ");
double usia = Convert.ToDouble(Console.ReadLine());

Console.Write("Input berat badan: ");
double beratBadan = Convert.ToDouble(Console.ReadLine());

Console.Write("Input Tinggi badan: ");
double tinggiBadan = Convert.ToDouble(Console.ReadLine());

double imt = beratBadan / (tinggiBadan * tinggiBadan);

Console.WriteLine($"\nIMT Anda: {imt:F2}");

if (usia >= 1 && usia <= 17)
{
    if (imt < 14)
    {
        Console.WriteLine("kurus");
    }
    else if (imt >= 14 && imt < 18)
    {
        Console.WriteLine("normal");
    }
    else
    {
        Console.WriteLine("kelebihan berat badan");
    }
}
else
{
    Console.WriteLine("Usia di luar rentang 1–17 tahun, program hanya untuk anak-anak.");

}