// See https://aka.ms/new-console-template for more information
/*--------------- LATIHAN 5------------------*/
Console.WriteLine("LATIHAN 5");

Console.Write("Input Nilai Numerik: ");
string nilaiNumerik = Console.ReadLine();
int angka2 = Convert.ToInt32(nilaiNumerik);

Console.Write("Input Karakter: ");
string txtKarakter = Console.ReadLine();
char karakter = char.Parse(txtKarakter);

string hasil =angka2 + karakter.ToString();

Console.WriteLine($"output adalah {hasil}");
