// See https://aka.ms/new-console-template for more information

/*--------------- LATIHAN 4 OPERASI------------------*/
Console.WriteLine("LATIHAN 4");

Console.Write("Input jumlah setiap kotak: ");
int jumlahSetiapKotak = Convert.ToInt32(Console.ReadLine());

Console.Write("Input kapasitas setiap kotak: ");
int kapasitasSetiapKotak = Convert.ToInt32(Console.ReadLine());

int sisaBarang = jumlahSetiapKotak % kapasitasSetiapKotak;
int jumlahKotakPenuh = jumlahSetiapKotak / kapasitasSetiapKotak;

Console.WriteLine($"Diperlukan {jumlahKotakPenuh} kotak penuh dan sisa barang yang belum dibungkus {sisaBarang} buah.");
