//String metotlarını araştırınız. Her bir metot için örnek yapınız.

//  ToUpper() - ToLower() - Concat()- Trim() - TrimStart() - TrimEnd() 
//  - Replace() -  IndexOf()- Contains() - Format() - Split()
//  - Substring()  - ToCharArray() - StartsWith() - EndsWith() 
//  -  PadLeft() - PadRight() - IsNullOrEmpty() - IsNullOrWhiteSpace()


string title1 = "Lorem ipsum dolor sit amet.";
string title2 = "Excepteur sint occaecat cupidatat.";

//  ToUpper() 
Console.WriteLine("ToUpper() Kullanımı");
Console.WriteLine(title1.ToUpper());
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();

// ToLower()
Console.WriteLine("ToLower() Kullanımı");
Console.WriteLine(title1.ToLower());
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();

// Concat()
Console.WriteLine("Concat() Kullanımı");
Console.WriteLine(string.Concat(title1," + ",title2));
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();

// Trim() - TrimStart() - TrimEnd()
Console.WriteLine("Trim() - TrimStart() - TrimEnd() Kullanımı");
string title3 = "   Hello World   ";

Console.WriteLine(title3);
Console.WriteLine(title3.Trim());
Console.WriteLine(title3.TrimStart());
Console.WriteLine(title3.TrimEnd());
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();

// Replace()
Console.WriteLine("Replace() Kullanımı");
Console.WriteLine(title3.Trim().Replace("World", "Türkiye"));
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();

// IndexOf()
Console.WriteLine("IndexOf() Kullanımı");
Console.WriteLine(title1.IndexOf("dolor"));
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();

// Contains() 
Console.WriteLine("Contains() Kullanımı");
Console.WriteLine(title1.Contains("amet"));
Console.WriteLine(title1.Contains("natus"));
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();

// Format()
Console.WriteLine("Format() Kullanımı");
Console.WriteLine(string.Format("Lorem {0} ipsum {0} dolor", "-"));
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();

// Split()
Console.WriteLine("Split() Kullanımı");
string title4 = "Lorem, ipsum, dolor sit, amet.";
string[] array = title4.Split(',');

Console.WriteLine(array[0]);

foreach (var item in array)
{
Console.Write(item + " - ");
}
Console.WriteLine("\n-------------------------------------------------");
Console.WriteLine();

// Substring()
Console.WriteLine("Substring() Kullanımı");
Console.WriteLine(title1.Substring(6));
Console.WriteLine(title1.Substring(6,5));
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();

// ToCharArray()
Console.WriteLine("ToCharArray() Kullanımı");
char[] array2 = title3.Trim().ToCharArray();
foreach (var item in array2)
{
    Console.WriteLine(item + ",");
}
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();

// StartsWith() - EndsWith()
Console.WriteLine("StartsWith() - EndsWith() Kullanımı");
Console.WriteLine(title3.Trim().StartsWith("Hello"));
Console.WriteLine(title3.Trim().EndsWith("World"));
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();

//  PadLeft() - PadRight()
Console.WriteLine("PadLeft() - PadRight() Kullanımı");
string title5 = "Hello";
Console.WriteLine(title5.PadLeft(10,'+'));
Console.WriteLine(title5.PadRight(10, '+'));
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();

// IsNullOrEmpty()
Console.WriteLine("IsNullOrEmpty() Kullanımı");
Console.WriteLine(string.IsNullOrEmpty(title5));
Console.WriteLine("-------------------------------------------------");
Console.WriteLine();

// IsNullOrWhiteSpace()
string title6 = "    ";
Console.WriteLine("IsNullOrWhiteSpace() Kullanımı");
Console.WriteLine(string.IsNullOrWhiteSpace(title5));
Console.WriteLine(string.IsNullOrWhiteSpace(title6));
Console.WriteLine("-------------------------------------------------");
