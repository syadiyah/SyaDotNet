// See https://aka.ms/new-console-template for more information

/*--------------- LATIHAN 10 OPERASI------------------*/
Console.Write("Input jam kerja perminggu: ");
double jumlahJamKerja = Convert.ToDouble(Console.ReadLine());

Console.Write("Input gaji perjam: ");
double gajiPerjam = Convert.ToDouble(Console.ReadLine());

double gajiKotor = jumlahJamKerja * gajiPerjam;

double pajak = gajiKotor * 0.10;

gajiKotor -= pajak;

double gajiBersih = gajiKotor;

Console.WriteLine($"Gaji kotor : {gajiKotor :c}, jumlah pajak : {pajak :c}, dan gaji bersih yang di terima {gajiBersih :c}");