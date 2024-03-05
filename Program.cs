// Kullanıcıdan öğrenci sayısını isteyen
// her öğrenci için öğrenci adı,öğrenci soyadı,1.sınav notu,2.sınav notu,3.sınav notu isteyen
// ve daha sonra not ortalamasını hesaplayıp ekrana yazdıran algoritma yapınız.
// (For döngüsü kullanınız)

Console.Write("Lütfen öğrenci sayısını giriniz : ");
int studentCount = int.Parse(Console.ReadLine());
double examTotalScore = 0;
int examCount = 3;

for (int i = 1; i <= studentCount; i++)
{
    Console.Write($"Lütfen {i}. öğrencinin ismini giriniz : ");
    string name = Console.ReadLine();

    Console.Write($"Lütfen {i}. öğrencinin soyismini giriniz : ");
    string surname = Console.ReadLine();

    for (int j = 1; j <= examCount; j++)
    {
        Console.Write($"Lütfen {i}. öğrencinin {j}.sınav notunu giriniz : ");
        int examScore = int.Parse(Console.ReadLine());
        examTotalScore += examScore;
    }

    double average = examTotalScore / examCount;

    Console.WriteLine($"{examCount} sınavın ortalaması : {average} \n");
    examTotalScore = 0;
}