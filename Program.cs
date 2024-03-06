// Do-While ve While döngüsü nedir? Bununla ilgili örnek yapınız.

//while Döngüsü: while döngüsü, belirli bir koşul sağlandığı sürece döngüyü çalıştıran bir kontrol yapısıdır.
//    Koşul doğru olduğu müddetçe döngü devam eder, koşul yanlış olduğunda döngü sona erer.

//do while Döngüsü: do while döngüsü, döngü içindeki işlemleri en az bir kez gerçekleştirir ve ardından koşulu kontrol eder. 
//    Koşul doğru olduğu sürece döngü devam eder, yanlış olduğunda döngü sona erer.

//do while döngüsü, özellikle döngü içindeki işlemlerin en az bir kez gerçekleştirilmesi istendiğinde kullanışlıdır,
//    çünkü koşul kontrolü döngüden önce gerçekleşir.Bu, do-while döngüsünü while döngüsünden farklı kılar.



#region WhileOrnek
//while (true)
//{
//    Console.Write("Bir sayı giriniz veya çıkmak için 'Q' tuşuna basınız: ");
//    //  int number = int.Parse(Console.ReadLine());
//    ConsoleKeyInfo keyInfo = Console.ReadKey();

//    if (keyInfo.KeyChar =='q' )
//    {
//        Console.WriteLine(" Programdan çıkılıyor...");
//        break;
//    }
//    else
//    {
//        char number = keyInfo.KeyChar;
//        Console.WriteLine($" Girilen sayı değeri: {number}'dır. Kayıt eklendi.");
//    }
//}
#endregion


#region Do-WhileOrnek

List<Question> questions = new List<Question>
{
    new Question()
    {
        ID = 1, Title = "Hangi gezegen Güneş Sistemi'nde üçüncü sıradadır?",
        OptionA = "Mars", OptionB = "Dünya", OptionC = "Jüpiter", OptionD = "Venüs", Correct = "B"
    },
    new Question()
    {
        ID = 2, Title = "En büyük gezegen hangisidir?",
        OptionA = "Mars", OptionB = "Venüs", OptionC = "Jüpiter", OptionD = "Satürn", Correct = "C"
    },
    new Question()
    {
        ID = 3, Title = "Güneş sisteminde kaç gezegen vardır?",
        OptionA = "6", OptionB = "8", OptionC = "10", OptionD = "12", Correct = "B"
    }
};

int i = 0;
do
{
    Console.WriteLine((i + 1) + "- " + questions[i].Title);
    ShowOptions(questions[i]);
    Console.Write("Lütfen cevabınızı giriniz (Cevabınızı girerken A,B,C ya da D şeklinde yazınız.): ");
    string answer = Console.ReadLine();

    if (questions[i].Correct.ToLower() == answer.ToLower())
    {
        Console.WriteLine("Tebrikler Cevabınız Doğru...");
        Console.WriteLine();
        i++;
    }
    else
    {
        Console.WriteLine($"Üzgünüz Cevabınız yanlış. Doğru cevap {questions[i].Correct} ");
        break;
    }

} while (i < questions.Count);

void ShowOptions(Question q)
{
    Console.WriteLine("A- " + q.OptionA);
    Console.WriteLine("B- " + q.OptionB);
    Console.WriteLine("C- " + q.OptionC);
    Console.WriteLine("D- " + q.OptionD);
    Console.WriteLine();
}
class Question
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string OptionA { get; set; }
    public string OptionB { get; set; }
    public string OptionC { get; set; }
    public string OptionD { get; set; }

    public string Correct { get; set; }

}
#endregion