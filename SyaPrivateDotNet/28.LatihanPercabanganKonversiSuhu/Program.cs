// See https://aka.ms/new-console-template for more information


Console.Write("Pilih jenis konversi C/F): ");
char pilihan = char.ToUpper(Console.ReadKey().KeyChar);
Console.WriteLine(); 

Console.Write("Masukkan nilai suhu: ");
double suhu = double.Parse(Console.ReadLine());

double hasil;

if (pilihan == 'C')
{
    hasil = (suhu * 9 / 5) + 32;
    Console.WriteLine($"{suhu}°C = {hasil}°F");
}
else if (pilihan == 'F')
{
    hasil = (suhu - 32) * 5 / 9;
    Console.WriteLine($"{suhu}°F = {hasil}°C");
}
else
{
    Console.WriteLine("Pilihan tidak valid. Ketik 'C' atau 'F'.");
}