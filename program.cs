using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Test");  // Simple test message

        // Variable declarations
        int kilo = 82;  // Integer variable
        string plaka = "73 NHT 1903";  // String variable
        long aracKilometre = 120000;  // Long variable
        char id = 'N';  // Char variable
        bool urunVarmi = true;  // Boolean variable
        double maas = 100524.25;  // Double variable
        string isimSoyisim = "Nihat Bayram";  // String variable
        char subeKodu = 'b';  // Char variable

        // Printing variables using string interpolation
        Console.WriteLine($"Kilo: {kilo}");
        Console.WriteLine($"Plaka: {plaka}");
        Console.WriteLine($"Arac Kilometre: {aracKilometre}");
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Urun Varmi: {urunVarmi}");
        Console.WriteLine($"Maas: {maas}");
        Console.WriteLine($"Isim Soyisim: {isimSoyisim}");
        Console.WriteLine($"Sube Kodu: {subeKodu}");

        // Integer variables example
        int sayi = 15;    // Integer variable
        int sayi2 = 20;   // Another integer variable
        Console.WriteLine($"Toplam: {sayi + sayi2}");  // Adding and printing the result

        // Floating point (float) variables example
        float sayi3 = 15.5f;   // Float variable
        float sayi0 = 15.54f;  // Another float variable
        Console.WriteLine($"Toplam: {sayi3 + sayi0}");  // Adding and printing the result

        // Double and Decimal variables example
        double sayi4 = 15.5;   // Double variable
        decimal sayi5 = 15.5m;  // Decimal variable (more precise calculations)

        // Type conversion between double and decimal
        decimal sonuc = (decimal)sayi4 + sayi5; // Converting double to decimal for addition
        Console.WriteLine($"Sonuc: {sonuc}");  // Printing the result in decimal format
    }
}
