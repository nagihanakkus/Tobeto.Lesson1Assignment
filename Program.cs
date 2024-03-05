

// 1- Switch - case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.


while (true)
{

    Console.Write("Lütfen sipariş numaranızı giriniz : ");
    string orderNumber = Console.ReadLine();

    string productName = "";

    switch (orderNumber)
    {
        case "1":
            productName = "Kalem";
            break;

        case "2":
            productName = "Kitap";
            break;

        case "3":
            productName = "Defter";
            break;

        case "4":
            productName = "Silgi";
            break;

        case "5":
            productName = "Cetvel";
            break;

        case "6":
            productName = "Pergel";
            break;

        case "7":
            productName = "Sulu Boya";
            break;

        case "8":
            productName = "KalemTıraş";
            break;

        case "9":
            productName = "Pastel Boya";
            break;

        case "10":
            productName = "Ajanda";
            break;

        default:
            productName = "-1";
            break;
    }

    string successMessage = $"Sipariş edilen ürün: {productName}";
    string notFoundMessage = "Aradığınız ürün bulunamadı.";

    Console.WriteLine((productName == "-1") ? notFoundMessage : successMessage);
    Console.WriteLine();


}


