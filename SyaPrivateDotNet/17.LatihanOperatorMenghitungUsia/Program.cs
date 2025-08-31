// See https://aka.ms/new-console-template for more information

/*--------------- LATIHAN 7 OPERASI------------------*/
Console.Write("Input Usia total dalam hari: ");

int usiaTotalDalamHari = Convert.ToInt32(Console.ReadLine());

int usiaDalamTahun = usiaTotalDalamHari / 365;

int sisaHari = usiaTotalDalamHari % 365;

Console.WriteLine($"Anda berusia {usiaDalamTahun} tahun dan sisa hari anda adalah {sisaHari} hari");
