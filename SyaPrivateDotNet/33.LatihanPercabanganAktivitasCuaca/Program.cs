// See https://aka.ms/new-console-template for more information

Console.Write("Input cuaca: ");
string cuaca = Console.ReadLine();


if (cuaca == "Hujan")
{
    Console.WriteLine("Membaca buku dirumah");
}
else if (cuaca == "Cerah")
{
    Console.WriteLine("Pergi ke taman atau pantai");
}
else if (cuaca == "Berawan")
{
    Console.WriteLine("Jalan jalan sore");
}
else
{
    Console.WriteLine("tetap waspada");
}

