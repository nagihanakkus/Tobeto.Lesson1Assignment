// Bir sayının mükemmel sayı olup olmadığı kontrol eden algoritma yazınız.

while (true)
{
    Console.Write("Lütfen bir sayı giriniz : ");
    double number = double.Parse(Console.ReadLine());
    double total = 0;

    for (double i = 1; i < number; i++)
    {
        if (number % i == 0)
        {
            total += i;
        }
    }

    if (total == number)
    {
        Console.WriteLine($"{number} sayısı mükemmel sayıdır.\n");
    }
    else
    {
        Console.WriteLine($"{number} sayısı mükemmel sayı değildir.\n");
    }
}

