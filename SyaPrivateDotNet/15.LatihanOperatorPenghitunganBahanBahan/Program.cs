// See https://aka.ms/new-console-template for more information

/*--------------- LATIHAN 5 OPERASI------------------*/
Console.WriteLine("LATIHAN 5");

Console.Write("Input jumlah porsi: ");
int jumlahPorsi = Convert.ToInt32(Console.ReadLine());

Console.Write("Input jumlah telur perporsi: ");
int jumlahTelur = Convert.ToInt32(Console.ReadLine());

Console.Write("Input jumlah tepung perporsi: ");
double jumlahTepung = Convert.ToDouble(Console.ReadLine());

int jumlahTotalTelur = jumlahPorsi * jumlahTelur;

int jumlahTotalTepung = Convert.ToInt32(jumlahTepung) * jumlahPorsi;

Console.WriteLine($"Dibutuhkan {jumlahTotalTelur} butir telur dan membutuhkan {jumlahTotalTepung} gram tepung.");