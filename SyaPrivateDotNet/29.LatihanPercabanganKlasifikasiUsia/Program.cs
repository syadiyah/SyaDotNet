// See https://aka.ms/new-console-template for more information

Console.Write("Masukkan usia: ");
int usia = int.Parse(Console.ReadLine());

if (usia >= 0 && usia <= 1)
{
    Console.WriteLine("Kategori: Bayi");
}
else if (usia >= 2 && usia <= 12)
{
    Console.WriteLine("Kategori: Anak-anak");
}
else if (usia >= 13 && usia <= 17)
{
    Console.WriteLine("Kategori: Remaja");
}
else if (usia >= 18 && usia <= 59)
{
    Console.WriteLine("Kategori: Dewasa");
}
else if (usia >= 60)
{
    Console.WriteLine("Kategori: Lansia");
}
else
{
    Console.WriteLine("Usia tidak valid");
}
