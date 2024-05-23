// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Hello, World!");

int x = 10;

int d = 420; //Bir müşterinin kayıt olduğu andan bugüne geçen gün sayısı.
int daysSinceUserCreated = 645;
int musteriKayitOldugundanBuYanaGecenGunSayisi = 520;

//1. Anlamlı isimler kullanın!
bool banuAlkan = false;
//2. Kısaltma kullanmayın.
var hp = 0;
//HorsePower
//Hesap Planı
//HP Laptop
//HealthPoint
//HitPoint,
var healthPoint = 0;

//3. Değişken adı veri tipiyle uyumlu olsun.
int intNumber = 8;

bool isAccept = true;
if (isAccept)
{

}
//4. Özellikle kompleks tiplerde, instance isminde tipin adına gönderme yapın:
DataTable productsDataTable = new DataTable();
Random randomNumberGenerator = new Random();

//5. Birbirine benzeyen sembollerden Allar rızası için uzak durun :)

var o = 0;
var l = 1;

if (o == 1)
{
    o = l;
}

//6. Karmaşık
string passwordSample = "Passw0rd";

var charArray = passwordSample.ToCharArray();
bool isLetter = false;
bool isDigit = false;
bool isSymbol = false;

foreach (var partOfString in charArray)
{
    if (char.IsLetter(partOfString))
    {
        isLetter = true;
    }
    else if (char.IsDigit(partOfString))
    {
        isDigit = true;
    }
    else
    {
        isSymbol = true;
    }
}

bool isPassWordStrong = isSymbol && isLetter && isDigit;

if (isPassWordStrong)
{
    Console.WriteLine("Vallahi güçlü şifre :)");
}
else
{
    Console.WriteLine("Olmaz böyle şifre!");
}



List<int[]> cellsOnABoard = new List<int[]>();
List<int[]> getFlaggedCells()
{
    List<int[]> flaggedCells = new List<int[]>();
    foreach (var cell in cellsOnABoard)
    {
        if (cell[0] == CellState.Flagged)
        {
            flaggedCells.Add(cell);
        }
    }

    return flaggedCells;
}

public class CellState
{
    public const int Empty = 0;
    public const int Exploded = 1;
    public const int ShowTip = 2;
    public const int Flagged = 4;
}