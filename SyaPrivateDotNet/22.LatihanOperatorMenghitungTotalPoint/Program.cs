// See https://aka.ms/new-console-template for more information
Console.Write("Input Jumlah Belanja: ");
int JumlahBelanja = Convert.ToInt32(Console.ReadLine());

int totalPoin = JumlahBelanja / 1000 * 10;

totalPoin += 50;

Console.Write($"Total Point yang didapatkan setelah bonus : {totalPoin}");

