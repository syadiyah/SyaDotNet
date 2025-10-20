// See https://aka.ms/new-console-template for more information

Console.Write("Input Total belanja: ");
int totalBelanja = Convert.ToInt32(Console.ReadLine());

double diskon = 0;

if (totalBelanja > 500.000)
{
    diskon = 0.20;

} else if (totalBelanja >= 200.000 && totalBelanja <= 500.000)
{
    diskon = 0.10;
}
else
{
    diskon = 0;
}

double totalDiskon = totalBelanja * diskon;
double totalBayar = totalBelanja - totalDiskon;

Console.WriteLine($"Total belanja {totalBelanja :c}, diskon yang didapat {totalDiskon :c}, total yang harus dibayar {totalBayar :c}");
