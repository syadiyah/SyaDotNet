// See https://aka.ms/new-console-template for more information
/*--------------- LATIHAN 9 OPERASI------------------*/
Console.Write("Input suhu dalam celsius: ");
double suhuDalamCelsius = Convert.ToDouble(Console.ReadLine());

double suhuFarenheit = (suhuDalamCelsius * 9/5) + 32;

Console.WriteLine($"{suhuDalamCelsius} setara dengan {suhuFarenheit}");