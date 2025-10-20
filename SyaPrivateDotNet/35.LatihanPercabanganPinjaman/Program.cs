// See https://aka.ms/new-console-template for more information
Console.Write("Input penghasilan: ");
double penghasilan = Convert.ToDouble(Console.ReadLine());

Console.Write("Input status pekerjaan: ");
string statusPekerjaan = Console.ReadLine();

if (penghasilan >= 5000000)
{
    if (statusPekerjaan == "pegawai tetap")
    {
        Console.WriteLine("pinjaman disetujui");
    } else
    {
        Console.WriteLine("pinjaman perlu ditinjau dulu");
    }
}else
{
    Console.WriteLine("pinjaman ditolak");
}