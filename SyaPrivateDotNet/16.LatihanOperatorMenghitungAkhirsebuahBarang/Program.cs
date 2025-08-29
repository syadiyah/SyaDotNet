// See https://aka.ms/new-console-template for more information

/*--------------- LATIHAN 6 OPERASI------------------*/
Console.WriteLine("LATIHAN 6");

Console.Write("Input Harga awal barang: ");
double hargaAwal = Convert.ToDouble(Console.ReadLine());

double hargaAkhir = hargaAwal;

hargaAkhir *= 0.85;

Console.WriteLine($"Harga awal {hargaAwal:c} dan Harga akhir setelah diskon {hargaAkhir:c} ");
