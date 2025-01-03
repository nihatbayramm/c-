using System; // Gerekli kutuphane

class HesapMakinesi // HesapMakinesi adinda bir sinif tanimliyoruz
{
    // 'Run' metodunu public yapalim ki disaridan cagrilabilir olsun
    public static void Run()
    {
        // Islemler listesini ekrana yazdiriyoruz
        Console.WriteLine("1-Toplama");
        Console.WriteLine("2-Cikarma");
        Console.WriteLine("3-Carpma");
        Console.WriteLine("4-Bolme");
        Console.WriteLine("Seciminizi yapiniz:");

        // Kullanici secim yapiyor
        char secim = Console.ReadLine()[0]; // Kullanici girdisinin ilk karakterini aliyoruz
        switch (secim) // Secime gore islem belirlemek icin switch kullaniyoruz
        {
            case '1': // Eger secim 1 ise toplama islemi yapilacak
                Console.WriteLine("1. sayiyi giriniz:"); // Ilk sayiyi istiyoruz
                int sayi1 = Convert.ToInt32(Console.ReadLine()); // Kullanici girdisini int'e ceviriyoruz
                Console.WriteLine("2. sayiyi giriniz:"); // Ikinci sayiyi istiyoruz
                int sayi2 = Convert.ToInt32(Console.ReadLine()); // Ikinci girdiyi int'e ceviriyoruz
                Console.WriteLine($"Sonuc: {sayi1 + sayi2}"); // Toplama sonucu yazdiriyoruz
                break; // Islem tamam

            case '2': // Eger secim 2 ise cikarma islemi yapilacak
                Console.WriteLine("1. sayiyi giriniz:");
                int sayi3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2. sayiyi giriniz:");
                int sayi4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Sonuc: {sayi3 - sayi4}");
                break;

            case '3': // Eger secim 3 ise carpma islemi yapilacak
                Console.WriteLine("1. sayiyi giriniz:");
                int sayi5 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2. sayiyi giriniz:");
                int sayi6 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Sonuc: {sayi5 * sayi6}");
                break;

            case '4': // Eger secim 4 ise bolme islemi yapilacak
                Console.WriteLine("1. sayiyi giriniz:");
                int sayi7 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2. sayiyi giriniz:");
                int sayi8 = Convert.ToInt32(Console.ReadLine());
                if (sayi8 != 0) // Sifira bolme kontrolu
                {
                    Console.WriteLine($"Sonuc: {sayi7 / sayi8}");
                }
                else
                {
                    Console.WriteLine("Sifira bolme yapilamaz.");
                }
                break;

            default: // Gecersiz secim
                Console.WriteLine("Gecersiz secim.");
                break;
        }
    }
}
