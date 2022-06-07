namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdörtgen dikdörtgen = new Dikdörtgen();
            dikdörtgen.Kısakenar = 5 ;
            dikdörtgen.Uzunkenar = 8 ;
            System.Console.WriteLine("Class Alan hesabı : "+ dikdörtgen.AlanHeesapla());

            Dikdörtgen_Struct dikdörtgen_Struct ;
            dikdörtgen_Struct.Kısakenar = 5;
            dikdörtgen_Struct.Uzunkenar = 8 ;
            System.Console.WriteLine("Struct Alan hesabı : "+ dikdörtgen_Struct.AlanHeesapla());
            System.Console.WriteLine(Günler.Cumartesi);

            int sıcaklık = 32;
            if (sıcaklık <= (int)HavaDurumu.Soguk)
            {
                System.Console.WriteLine("Hava çok soğuk hava ısınması bekleyin");
            }
            else if(sıcaklık>= (int)HavaDurumu.Sıcak)
                System.Console.WriteLine("Dışarıya çıkmak için sıcak bir gün");

            else if(sıcaklık >= (int)HavaDurumu.Normal && sıcaklık < (int)HavaDurumu.cokSıcak)
                System.Console.WriteLine("Hadı dışarıya çıkalım");
        }

    }
    class Dikdörtgen
    {
        public int Kısakenar;
        public int Uzunkenar;

        public int AlanHeesapla()
        {
            return Kısakenar*Uzunkenar ;
        }
    }

    struct Dikdörtgen_Struct
    {
        public int Kısakenar;
        public int Uzunkenar;
        public int AlanHeesapla()
        {
            return Kısakenar*Uzunkenar ;
        }

    }
    enum Günler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar,
    }
    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sıcak = 25 ,
        cokSıcak = 39,


    }
}