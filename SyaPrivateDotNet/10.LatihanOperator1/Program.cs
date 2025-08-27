// See https://aka.ms/new-console-template for more information


//latihan1
int nilai1 = 50;
int nilai2 = 25;

int hasilPlus = nilai1 + nilai2;
int hasilKurang = nilai1 - nilai2;
int hasilKali = nilai1 * nilai2;
int hasilBagi = nilai1 / nilai2;

Console.WriteLine($"hasil tambah = {hasilPlus}, hasil kurang = {hasilKurang}, " +
    $"hasil kali = {hasilKali}, hasil bagi = {hasilBagi}");


//latihan2
int usia = 19;
bool punyaKTP = true;

string hasil2 = (usia >= 17 && punyaKTP) ? "Dapatkan SIM"  : "gagal";

Console.WriteLine(hasil2);

//latihan3
int sisaBagi = 100;
int sisaBagi2 = 9;

int hasilSisaBagi = sisaBagi % sisaBagi2;
Console.WriteLine($"hasil sisa bagi = {hasilSisaBagi}");

//latihan4
int hasil4 = (10 + 5) * 2 + 5;

Console.WriteLine(hasil4);

//latihan5
int nilaiA = 85;
int nilaiB = 90;
int nilaiC = 75;

double rataRata = (nilaiA + nilaiB + nilaiC) / 3;

Console.WriteLine($"rata rata: {rataRata} ");