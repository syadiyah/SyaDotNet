// See https://aka.ms/new-console-template for more information

/*--------------- LATIHAN 1 PERCABANGAN------------------*/
Console.Write("Input nilai: ");
string txtnilai = Console.ReadLine();

int nilai;

bool nilaiBool = int.TryParse(txtnilai, out nilai);

if (nilaiBool)
{
    if (nilai >= 0 && nilai <= 100)
    {

        if (nilai >= 90)
        {
            Console.WriteLine("Predikat A");
        }
        else if (nilai >= 80 && nilai <= 89)
        {
            Console.WriteLine("Predikat B");
        }
        else if (nilai >= 70 && nilai <= 79)
        {
            Console.WriteLine("Predikat c");
        }
        else if (nilai >= 60 && nilai <= 69)
        {
            Console.WriteLine("Predikat d");
        }
        else
        {
            Console.WriteLine("predikat e");
        }
    }
    else
    {
        Console.WriteLine("silakan input nilai dari 0 - 100");
    }
}
else
{
    Console.WriteLine("Hanya boleh input angka");
}
