
// Kullanıcının 1 ile 10 arasında rastgele bir sayıyı tahmin etmesini isteyen
// ve doğru tahmin edene kadar devam eden bir program yazınız.
// (While döngüsü ile yapınız ve rastgele sayı üretmek için Random sınıfını kullanınız)

Random random = new Random();
int randomNumber = random.Next(1, 10);

while (true)
{
    Console.Write("Lütfen bir sayı giriniz : ");
    int guess = int.Parse(Console.ReadLine());
    if (guess == randomNumber)
    {
        Console.WriteLine("Tebrikler Bildiniz\n");
        break;
    }
    else
    {
        Console.WriteLine("Tekrar Deneyin\n");
    }
}