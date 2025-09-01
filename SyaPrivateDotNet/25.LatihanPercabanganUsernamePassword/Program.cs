// See https://aka.ms/new-console-template for more information
Console.Write("Input Username: ");
string txtUsername = Console.ReadLine();

Console.Write("Input Password: ");
string txtPassword = Console.ReadLine();

if (txtUsername == "admin" && txtPassword == "123")
{
    Console.WriteLine("login berhasil");
}
else
{
    Console.WriteLine("login gagal");
}