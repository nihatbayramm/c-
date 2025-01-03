using System;

class veriTipleri
{
    public static void Run()
    {
     

        // Degisken tanimlamalari
        int kilo = 82;  // Tam sayi degiskeni
        string plaka = "73 NHT 1903";  // String degiskeni
        long aracKilometre = 120000;  // Uzun tam sayi degiskeni
        char id = 'N';  // Karakter degiskeni
        bool urunVarmi = true;  // Boolean (dogru/yanlis) degiskeni
        double maas = 100524.25;  // Ondalik sayi degiskeni (double)
        string isimSoyisim = "Nihat Bayram";  // String degiskeni
        char subeKodu = 'b';  // Karakter degiskeni

        // Degiskenleri string interpolasyonu ile yazdirma
        Console.WriteLine($"Kilo: {kilo}");
        Console.WriteLine($"Plaka: {plaka}");
        Console.WriteLine($"Arac Kilometre: {aracKilometre}");
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Urun Varmi: {urunVarmi}");
        Console.WriteLine($"Maas: {maas}");
        Console.WriteLine($"Isim Soyisim: {isimSoyisim}");
        Console.WriteLine($"Sube Kodu: {subeKodu}");

        // Tam sayi degiskenleri ornegi
        int sayi = 15;    // Tam sayi degiskeni
        int sayi2 = 20;   // Baska bir tam sayi degiskeni
        Console.WriteLine($"Toplam: {sayi + sayi2}");  // Toplama yapip sonucu yazdirma

        // Ondalik sayi (float) degiskenleri ornegi
        float sayi3 = 15.5f;   // Float degiskeni
        float sayi0 = 15.54f;  // Baska bir float degiskeni
        Console.WriteLine($"Toplam: {sayi3 + sayi0}");  // Toplama yapip sonucu yazdirma

        // Double ve Decimal degiskenleri ornegi
        double sayi4 = 15.5;   // Double degiskeni
        decimal sayi5 = 15.5m;  // Decimal degiskeni (daha hassas hesaplamalar)

        // Double ve decimal arasinda tip donusumu
        decimal sonuc = (decimal)sayi4 + sayi5; // Double'i decimal'a donusturerek toplama
        Console.WriteLine($"Sonuc: {sonuc}");  // Sonucu decimal formatinda yazdirma
    
    }
}
