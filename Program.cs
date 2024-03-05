

// Kullanıcıdan kaç ürün almak istediğini soran,her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan bir algoritma yazınız


Console.Write("Lütfen kaç ürün almak istediğinizi belirtiniz: ");

int productCount = int.Parse(Console.ReadLine());
double totalAmount = 0;

for (int i = 1; i <= productCount; i++)
{
    Console.Write($"Lütfen {i}. ürünün fiyatını giriniz(Ondalıklı değerlerde virgül(,) kullanınız):  ");
    double amount = double.Parse(Console.ReadLine());

    totalAmount += amount;
}

Console.WriteLine($"{productCount} Ürünün Toplam Tutarı : {totalAmount}");
