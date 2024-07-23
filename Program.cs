



using System.Diagnostics.Tracing;

int fatura = 0; 
bool dogru = true;


while(dogru)
{
    Console.WriteLine("Hangi şehre gideceksin? Bodrum Marmaris Çeşme");
    string lokasyonAdi = Console.ReadLine().Trim().ToLower();

    if (lokasyonAdi == "bodrum")
    {
        fatura = 4000;
        dogru = false;
    }

    else if (lokasyonAdi == "çeşme")
    {
        fatura = 5000;
        dogru = false;
    }

    else if (lokasyonAdi == "çeşme")
    {
        fatura = 6000;
        dogru = false;
    }

    else { Console.WriteLine("Doğru yazınız şehri\n"); }
    
    }

Console.WriteLine("Kaç kişisiniz");
int kişi  = Convert.ToInt32(Console.ReadLine());

while(!dogru)
{
    Console.WriteLine("Nasıl gitmek istersin 1 mi 2 mi");
    Console.WriteLine("1- Hava yolu : kişi başı 2000 tl");
    Console.WriteLine("2- Kara yolu : kişi başı 1000 tl");

   int secim =Convert.ToInt32(Console.ReadLine());
    int yolMasraf = 0;

    if (secim == 1)
    {
        yolMasraf = kişi * 2000;
        fatura += yolMasraf;
        dogru = true;
    }
    else if (secim == 2)
    {
        yolMasraf = kişi * 1000;
        fatura += yolMasraf;
        dogru = true;
    }

    else
    {
        Console.WriteLine("doğru bir değer gir");
    }
}

Console.WriteLine($"toplam tutar {fatura}");

Console.WriteLine("başka bir tatil planlamak istiyor musunuz ? evet hayır ");
