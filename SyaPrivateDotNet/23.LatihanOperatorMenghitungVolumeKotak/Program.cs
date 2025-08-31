// See https://aka.ms/new-console-template for more information

Console.Write("Input panjang kotak: ");
double panjangKotak = Convert.ToDouble(Console.ReadLine());

Console.Write("Input lebar kotak: ");
double lebarKotak = Convert.ToDouble(Console.ReadLine());

Console.Write("Input tinggi kotak: ");
double tinggiKotak = Convert.ToDouble(Console.ReadLine());

double volumeKotak = panjangKotak * lebarKotak * tinggiKotak;

Console.WriteLine($"Volume kotak = {volumeKotak} cm2" );