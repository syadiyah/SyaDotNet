// See https://aka.ms/new-console-template for more information
/*--------------- LATIHAN 11 OPERASI------------------*/
Console.Write("Input Nilai Tukar: ");
double nilaiTukar = Convert.ToDouble(Console.ReadLine());

Console.Write("Input jumlah dolar  AS: ");
double jumlahDolar = Convert.ToDouble(Console.ReadLine());

double totalRupiah = jumlahDolar *  nilaiTukar;

Console.WriteLine($"Total Rupiah yang anda dapatkan adalah {totalRupiah :c}");