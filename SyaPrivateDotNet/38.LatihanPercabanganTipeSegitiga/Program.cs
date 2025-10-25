// See https://aka.ms/new-console-template for more information


Console.Write("Masukkan sisi a: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Masukkan sisi b: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Masukkan sisi c: ");
double c = Convert.ToDouble(Console.ReadLine());

if (a + b > c && a + c > b && b + c > a)
{
    if (a == b && b == c)
    {
        Console.WriteLine("Segitiga Sama Sisi");
    }
    else if (a == b || b == c || a == c)
    {
        Console.WriteLine("Segitiga Sama Kaki");
    }
    else
    {
        Console.WriteLine("Segitiga Sembarang");
    }
}
else
{
    Console.WriteLine("tidak membentuk segitiga.");
}