// See https://aka.ms/new-console-template for more information

Console.Write("Input nilai: ");
string txtnilai = Console.ReadLine();

int nilai;

bool nilaiBool = int.TryParse(txtnilai, out nilai);

if (nilaiBool)
{
    if (nilai > 0)
    {
        Console.WriteLine("positif");
    }
    else if (nilai < 0)
    {
        Console.WriteLine("negatif");
    }
    else
    {
        Console.WriteLine("nol");
    }
} else
{
    Console.WriteLine("hanya boleh angka");
}