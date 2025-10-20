// See https://aka.ms/new-console-template for more information
Console.Write("Input angka pertama: ");
int angkaPertama = Convert.ToInt32(Console.ReadLine());

Console.Write("Input operator (+,-,*,/): ");
char operatornya = Convert.ToChar(Console.ReadLine());

Console.Write("Input angka kedua: ");
int angkaKedua = Convert.ToInt32(Console.ReadLine());

int hasil = 0;

if (operatornya == '+' || operatornya == '-' || operatornya == '*' || operatornya == '/')
{
    if (operatornya == '+')
    {
        hasil = angkaPertama + angkaKedua;
    }

    if (operatornya == '-')
    {
        hasil = angkaPertama - angkaKedua;
    }

    if (operatornya == '*')
    {
        hasil = angkaPertama * angkaKedua;
    }

    if (operatornya == '/')
    {
        hasil = angkaPertama / angkaKedua;
    }

    Console.WriteLine(hasil);
} else
{
    Console.WriteLine("Operator yang diinput harus sesuai dengan ketentuan");
}