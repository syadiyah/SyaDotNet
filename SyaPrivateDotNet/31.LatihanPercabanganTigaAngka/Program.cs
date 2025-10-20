// See https://aka.ms/new-console-template for more information

Console.Write("Input angka1: ");
string txtAngka1 = Console.ReadLine();


Console.Write("Input angka2: ");
string txtAngka2 = Console.ReadLine();

Console.Write("Input angka3: ");
string txtAngka3 = Console.ReadLine();

int nilai1;
int nilai2;
int nilai3;

bool nilaiBool1 = int.TryParse(txtAngka1, out nilai1);
bool nilaiBoo12 = int.TryParse(txtAngka2, out nilai2);
bool nilaiBoo13 = int.TryParse(txtAngka3, out nilai3);

if (nilaiBool1 && nilaiBoo12 && nilaiBoo13)
{
    if (nilai1 > nilai2 && nilai1 > nilai3)
    {
        Console.WriteLine($"angka terbesar adalah : {nilai1}");
    }
    else if (nilai2 > nilai1 && nilai2 > nilai3)
    {
        Console.WriteLine($"angka terbesar adalah : {nilai2}");
    }
    else
    {
        Console.WriteLine($"angka terbesar adalah : {nilai3}");
    }
}
else
{
    Console.WriteLine("hanya boleh angka");
}