// See https://aka.ms/new-console-template for more information
/*--------------- LATIHAN 2 OPERASI------------------*/
Console.WriteLine("LATIHAN 2");

Console.Write("Input harga bensin perliter: ");
double hargaBensin = Convert.ToDouble(Console.ReadLine());

Console.Write("Input Jarak tempuh: ");
int jarakTempuh = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Kosumsi bahan bakar: ");
double kosumsiBahanBakar = Convert.ToDouble(Console.ReadLine());

double totalBensin = jarakTempuh / kosumsiBahanBakar;
double totalBiayaPerjalanan = totalBensin * hargaBensin;


Console.WriteLine($"Bensin yang dibutuhkan adalah {totalBensin} liter dan total biaya perjalanan anda adalah {totalBiayaPerjalanan:c}");