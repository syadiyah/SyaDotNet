// See https://aka.ms/new-console-template for more information

/*--------------- LATIHAN 8 OPERASI------------------*/
Console.Write("Input Nilai Tugas: ");
double nilaiTugas = Convert.ToDouble(Console.ReadLine());

Console.Write("Input Nilai UTS: ");
double nilaiUTS = Convert.ToDouble(Console.ReadLine());

Console.Write("Input Nilai UAS: ");
double nilaiUAS = Convert.ToDouble(Console.ReadLine());

double nilaiAkhir = nilaiTugas * 0.2 + nilaiUTS * 0.3 + nilaiUAS * 0.5;

Console.WriteLine($"Nilai akhir anda {nilaiAkhir}");