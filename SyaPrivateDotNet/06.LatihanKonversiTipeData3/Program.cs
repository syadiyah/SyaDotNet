// See https://aka.ms/new-console-template for more information

/*--------------- LATIHAN 3------------------*/
Console.WriteLine("LATIHAN 3");

Console.Write("Usia: ");

string textUsia = Console.ReadLine();
int usia = Convert.ToInt32(textUsia);

bool usiaBool = int.TryParse(textUsia, out usia);

Console.WriteLine($"Usia Anda adalah {usia} tahun ");

