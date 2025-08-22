// See https://aka.ms/new-console-template for more information


//typedata cuma ada 2 huruf dan angka. string dan angkat

int kodeHuruf = 75;
char huruf = (char)kodeHuruf;


int angka = 123;
string text = angka.ToString();

int jumlah = 19;
string pesanan = $"ada {jumlah} item di keranjang"; //bisa seperti ini tapi dialisakannya, interpolesion dengan ditambah $ didepannya.

double gaji = 1000.00;
int gajibulat = (int)gaji; //jika double ingin di convert ke int akan merubah nilai menjadi bulat

double kodeUnik1 = 65.5;
char karakter1 = (char)kodeUnik1; //akan mengubah ke char dan hanya membaca 65

double harga = 150.70;
string hargatext = harga.ToString();

string textangka = "123";
int angka2 = Convert.ToInt32(textangka); //perdedaan antar t
int angka3 = int.Parse(textangka); //

Console.WriteLine(huruf);
Console.WriteLine(text);
Console.WriteLine(pesanan);
Console.WriteLine(gajibulat);
Console.WriteLine(karakter1);
Console.WriteLine(hargatext);
Console.WriteLine(angka2);
Console.WriteLine(angka3);

string angkavalid = "780";
int hasilangka;
bool sukses = int.TryParse(angkavalid, out hasilangka);  // variable out itu hasil conversi yang akan diliat dari hasilangka itu
Console.WriteLine(sukses);
Console.WriteLine(hasilangka);

string angkavaliddouble = "780";
double hasilangkadouble;
bool suksesdouble = double.TryParse(angkavaliddouble, out hasilangkadouble);  // variable out itu hasil conversi yang akan diliat dari hasilangka itu
Console.WriteLine(suksesdouble);
Console.WriteLine(hasilangkadouble);

string angkavaliddecimal = "780";
decimal hasilangkadecimal;
bool suksesdecimal = decimal.TryParse(angkavaliddecimal, out hasilangkadecimal);  // variable out itu hasil conversi yang akan diliat dari hasilangka itu
Console.WriteLine(suksesdecimal);
Console.WriteLine(hasilangkadecimal);

decimal angka1 = 15.70m;
int hasilangka1 = Convert.ToInt32(angka1); //decimal itu  pecahan, int itu bilangan bulat. int akan mengconvert hasil decimal kebilangan genap 2,4,dll
Console.WriteLine(hasilangka1);

decimal angkatruncate = 15.70m;
int hasilangkatruncate = (int)Math.Truncate(angkatruncate); //truncate digunakan untuk memangkas angka dibelakangnya
Console.WriteLine(hasilangkatruncate);

int hasilangkaround = (int)Math.Round(angkatruncate); //round untuk dibulatkan keatas, tapi jika angkatruncate dibawah 15.25 hasilnya akan 15.
Console.WriteLine(hasilangkaround); //


int hasilangkaCelling = (int)Math.Ceiling(angkatruncate); //akan dibulatkan menjadi keatas mau dibelakangnya diatas 50 atau dibawh 50
Console.WriteLine(hasilangkaCelling);

int hasilangkaFloor = (int)Math.Floor(angkatruncate); // akan memunculkan nilai depannya saja, tanpa lihat nilai belakangnya mau diatas 50 atau dibawah 50.
Console.WriteLine(hasilangkaFloor);


decimal angkadecimal2 = 1234.098765m;
double hasilangkadecimal2 = Convert.ToDouble(angkadecimal2);
Console.WriteLine(hasilangkadecimal2);

decimal suhu = 25.456m;
string textSuhu = suhu.ToString("F2"); //F2 untuk ambil digit dibelakang koma
Console.WriteLine(textSuhu);

decimal pajak = 12.5m;
string textpajak = $"pajak {pajak:C}"; // :C dibelakang itu adalah curonc
Console.WriteLine(textpajak);

