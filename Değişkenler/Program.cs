
byte b = 5; //1 byte
sbyte c = 5;//1 byte
short s = 5; //2 byte
ushort us = 5;//2 byte
Int16 i16 = 2;//2 byte
int i = 2; //4 byte
Int32 i32 = 2;//4 bvyte
Int64 i64 = 2;//8 byte
uint ui = 2;//4 byte
long l = 4;//8 byte
ulong ul = 4;//8 byte

//Reel sayılar
float f = 5; //4 byte
double d = 5; //8 byte
decimal de= 5; //16 byte

char ch= '2'; //2 byte
string str = "Aziz"; //sınırsız

bool b1=true;
bool b2=false;

DateTime dt1 = DateTime.Now;
Console.WriteLine(dt1);

object o1 = "x";
object o2 = "y";
object o3 = 4;
object o4 = 4.3;

//String İfadeler

string str1=string.Empty;
str1 = "Aziz Yılmaz";
string ad = "Aziz";
string soyad = "Yılmaz";
string tamIsım = ad + " " + soyad;
Console.WriteLine(tamIsım);

//İnteger tanımlama şekilleri

int integer1 = 5;
int integer2 = 3;
int integer3 = integer1*integer2;

//boolean

bool bool1 = 10 > 2;

//Değişken Dönüşümleri
string str20 = "20";
int int20 = 20;
string yeniDeger=str20 + int20.ToString();
Console.WriteLine(yeniDeger); //Çıktısı 2020

int  int21 = int20+Convert.ToInt32(str20);
Console.WriteLine(int21);// Çıktısı 40

int int22 =int20+int.Parse(str20); // Çıktısı 40

//datemtime

string datetime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime);

string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(datetime2);

//saat
string hour = DateTime.Now.ToString("HH:mm");
Console.WriteLine(hour);