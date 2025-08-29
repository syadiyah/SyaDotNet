// See https://aka.ms/new-console-template for more information

//kalau untuk harga lebih baik gunakan double atau decimal.
//kalu untuk usia udah pasti int.
//kalo qyt gunakan double.

/*--------------- LATIHAN 1 OPERASI------------------*/
Console.WriteLine("LATIHAN 1");

Console.Write("Input harga barang 1: ");
double barangDouble1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input harga barang 2: ");
double barangDouble2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input harga barang 3: ");
double barangDouble3 = Convert.ToDouble(Console.ReadLine());

double totalHarga =barangDouble1 + barangDouble2 + barangDouble3;

double medianHarga = (barangDouble1 + barangDouble2 + barangDouble3) / 3;

Console.WriteLine($"Total belanjaan adalah: {totalHarga:c} ");
Console.WriteLine($"rata rata harga perbarang: {medianHarga:c} ");

