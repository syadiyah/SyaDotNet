// See https://aka.ms/new-console-template for more information

/*--------------- LATIHAN 3 OPERASI------------------*/
Console.WriteLine("LATIHAN 3");

Console.Write("Input Saldo Awal: ");
int saldoAwal = Convert.ToInt32(Console.ReadLine());

int saldo = saldoAwal;

saldo += 150000;

saldo -= 75000;

Console.WriteLine($"Saldo awal Anda: {saldoAwal} :c");
Console.WriteLine($"Saldo akhir Anda: {saldo} :c");

