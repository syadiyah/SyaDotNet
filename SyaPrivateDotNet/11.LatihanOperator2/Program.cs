// See https://aka.ms/new-console-template for more information

/*--------------- LATIHAN 1 OPERASI------------------*/
Console.WriteLine("LATIHAN 1");

Console.Write("Input harga barang 1: ");
double barangDouble1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input harga barang 2: ");
double barangDouble2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input harga barang 3: ");
double barangDouble3 = Convert.ToDouble(Console.ReadLine());

int totalHarga = Convert.ToInt32(barangDouble1) + Convert.ToInt32(barangDouble2) + Convert.ToInt32(barangDouble3);

double medianHarga = (barangDouble1 + barangDouble2 + barangDouble3) / 3;

Console.WriteLine($"Total belanjaan adalah: {totalHarga:c} ");
Console.WriteLine($"rata rata harga perbarang: {medianHarga:c} ");


/*--------------- LATIHAN 2 OPERASI------------------*/
Console.WriteLine("LATIHAN 2");

Console.Write("Input harga bensin perliter: ");
double hargaBensin = Convert.ToDouble(Console.ReadLine());

Console.Write("Input Jarak tempuh: ");
int jarakTempuh = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Kosumsi bahan bakar: ");
double kosumsiBahanBakar = Convert.ToDouble(Console.ReadLine());

int totalBensin = jarakTempuh / Convert.ToInt32(kosumsiBahanBakar);
int totalBiayaPerjalanan = totalBensin * Convert.ToInt32(hargaBensin);


Console.WriteLine($"Bensin yang dibutuhkan adalah {totalBensin} liter dan total biaya perjalanan anda adalah {totalBiayaPerjalanan :c}");

/*--------------- LATIHAN 3 OPERASI------------------*/
Console.WriteLine("LATIHAN 3");

Console.Write("Input Saldo Awal: ");
int saldoAwal = Convert.ToInt32(Console.ReadLine());

int saldo = saldoAwal;

saldo += 150000;

saldo -= 75000;

Console.WriteLine($"Saldo awal Anda: {saldoAwal} :c");
Console.WriteLine($"Saldo akhir Anda: {saldo} :c");


/*--------------- LATIHAN 4 OPERASI------------------*/
Console.WriteLine("LATIHAN 4");

Console.Write("Input jumlah setiap kotak: ");
int jumlahSetiapKotak = Convert.ToInt32(Console.ReadLine());

Console.Write("Input kapasitas setiap kotak: ");
int kapasitasSetiapKotak = Convert.ToInt32(Console.ReadLine());

int sisaBarang = jumlahSetiapKotak % kapasitasSetiapKotak;
int jumlahKotakPenuh = jumlahSetiapKotak / kapasitasSetiapKotak;

Console.WriteLine($"Diperlukan {jumlahKotakPenuh} kotak penuh dan sisa barang yang belum dibungkus {sisaBarang} buah.");

/*--------------- LATIHAN 5 OPERASI------------------*/
Console.WriteLine("LATIHAN 5");

Console.Write("Input jumlah porsi: ");
int jumlahPorsi = Convert.ToInt32(Console.ReadLine());

Console.Write("Input jumlah telur: ");
int jumlahTelur = Convert.ToInt32(Console.ReadLine());

Console.Write("Input jumlah tepung: ");
double jumlahTepung = Convert.ToDouble(Console.ReadLine());

int jumlahTotalTelur = jumlahPorsi * jumlahTelur;

int jumlahTotalTepung = Convert.ToInt32(jumlahTepung) * jumlahPorsi;

Console.WriteLine($"Dibutuhkan {jumlahTotalTelur} butir telur dan membutuhkan {jumlahTotalTepung} gram tepung.");

/*--------------- LATIHAN 6 OPERASI------------------*/
Console.WriteLine("LATIHAN 6");

Console.Write("Input Harga awal barang: ");
double hargaAwal = Convert.ToDouble(Console.ReadLine());

double hargaAkhir = hargaAwal;

hargaAkhir *= 0.85;

Console.WriteLine($"Harga awal {hargaAwal:c} dan Harga akhir setelah diskon {hargaAkhir:c} ");