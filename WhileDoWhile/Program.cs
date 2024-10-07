// Kullanıcının girdiği bir limit değerine kadar konsol ekranına çıktı verip, while ile do-while farkını görcez

#region While

Console.Write("Bir sayı girin: ");

int limit1 = int.Parse(Console.ReadLine());

int counter1 = 0;

while (counter1 <= limit1)
{
    Console.WriteLine($"{counter1} - Ben bir Patika'lıyım");
    counter1++;
}

Console.WriteLine("\n----------------\n");

#endregion

#region Do-While

Console.Write("Bir sayı girin: ");

int limit2 = int.Parse(Console.ReadLine());

int counter2 = 0;

do
{
    Console.WriteLine($"{counter2} - Ben bir Patika'lıyım");
    counter2++;
}
while (counter2 <= limit2);
#endregion

// İkisi arasındaki temel fark while bir koşul yanlış ise hiç çalışmaz. Koşul > Blok > Koşul Blok şeklinde çalışır

// do-while bloğu ise koşul yanlış olsa bile bloğu bir kez çalıştır. Blok > Koşul > Blok > Koşul şeklinde çalışır
