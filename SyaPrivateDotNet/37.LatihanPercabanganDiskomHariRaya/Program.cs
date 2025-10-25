// See https://aka.ms/new-console-template for more information
Console.Write("Input Total Belanja: ");
int totalBelanja = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Hari: ");
string hari = Console.ReadLine();

double diskon = 0;

if (totalBelanja == 100000)
{
    if (hari == "rabu")
    {
        diskon = 0.15;
    } 
    else if (hari == "sabtu" ||  hari == "minggu")
    {
        diskon = 0.10;
    }
    else
    {
        diskon = 0.05;
    }
    double totalDiskon = totalBelanja * diskon;
    double totalBayar = totalBelanja - totalDiskon;

    Console.WriteLine($"total yang harus dibayar {totalBayar:c}");
}
else
{
    Console.WriteLine("tidak ada diskon");
}