// See https://aka.ms/new-console-template for more information


Console.Write("Input Tahun Kabisat: ");
string txtTahunKabisati = Console.ReadLine();

int tahunKabisat;

bool nilaiTahun = int.TryParse(txtTahunKabisati, out tahunKabisat);

if (tahunKabisat % 4 == 0)
{
    if (tahunKabisat % 100 == 0)
    {
        if (tahunKabisat % 400 == 0)
        {
            Console.WriteLine($"{tahunKabisat} adalah tahun kabisat");
        }
        else
        {
            Console.WriteLine($"{tahunKabisat} bukan tahun kabisat");
        }
    }
    else
    {
        Console.WriteLine($"{tahunKabisat} adalah tahun kabisat");
    }
}
else
{
    Console.WriteLine($"{tahunKabisat} bukan tahun kabisat");
}