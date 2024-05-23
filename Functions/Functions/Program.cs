// See https://aka.ms/new-console-template for more information
using Functions;

Console.WriteLine("Hello, World!");
/*
 * 1. One job at a time: Birim zamanda bir iş.
 * 2. Parametresi ne kadar azsa (hatta yoksa) o kadar iyi..(Minimum arguments)
 * 3. Gövde kodu olabildiğince az sayıdan oluşmalı.
 * 
 */

bool isEven(int number) => number % 2 == 0;

/*
 * 1. Kelime listesi içinden rastgele bir kelime seç.
 * 2. Bu kelimenin harf sayısı kadar "-" işareti oluştur.
 * 3. Ekranda "----" biçiminde bulmacayı göster
 * 4. Kullanıcıdan harf iste.
 * 5. Harfin kelimede olup olmadığına bak
 * 6. Varsa o pozisyondaki - işaretini harfer çevir. Yoksa haktan 1 azalt.
 */




string getRandomWord(List<string> words)
{
    return "eskişehir";
}

string convertPuzzleFromWord(string word)
{
    return "---------";
}

void showPuzzle(string word)
{
    Console.WriteLine(word);
}

string getLetterFromUser()
{
    return "e";
}

bool isIncludeLetter(string word, string letter)
{
    return true;
}
string replaceLetter(string letter, string puzzle)
{
    return "e----e---";
}

/*
 * 1. Kelime listesi içinden rastgele bir kelime seç.
 * 2. Bu kelimenin harf sayısı kadar "-" işareti oluştur.
 * 3. Ekranda "----" biçiminde bulmacayı göster
 * 4. Kullanıcıdan harf iste.
 * 5. Harfin kelimede olup olmadığına bak
 * 6. Varsa o pozisyondaki - işaretini harfer çevir. Yoksa haktan 1 azalt.
 */

var word = getRandomWord(new List<string>());
var puzzle = convertPuzzleFromWord(word);
showPuzzle(puzzle);
var letter = getLetterFromUser();
if (isIncludeLetter(letter, word))
{
    puzzle = replaceLetter(letter, word);
    showPuzzle(puzzle);
}
else
{

}

void changeProductPrice(double price)
{
    if (price < 0)
    {
        throw new ArgumentException("Fiyat negatif olamaz", nameof(price));
    }


}

try
{
    Report report = new Report("data.xlsx");
}
catch (ArgumentNullException)
{

    Console.WriteLine("Adres bilgisini giriniz.");
}
catch (FileNotFoundException)
{
    Console.WriteLine("Dosya bulunamadı");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}   