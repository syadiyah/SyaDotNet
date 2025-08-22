// See https://aka.ms/new-console-template for more information
using System;

/*--------------- LATIHAN 1------------------*/
Console.WriteLine("LATIHAN 1");

Console.Write("Input Harga Barang: ");

string textHargaBarang = Console.ReadLine();
decimal hargaBarang = Convert.ToDecimal(textHargaBarang);

Console.Write("Input Jumlah Barang: ");
string textJumlahBarang = Console.ReadLine();
int jumlahBarang = Convert.ToInt32(textJumlahBarang);

decimal totalHarga = jumlahBarang * hargaBarang;

Console.WriteLine($"Total Harga {totalHarga:C}");

/*--------------- LATIHAN 2------------------*/
