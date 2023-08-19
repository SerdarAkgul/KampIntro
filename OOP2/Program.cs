namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "serdar";
            musteri1.Soyadi = "akgül";
            musteri1.TcNo = "12123123123";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12312";
            musteri2.SirketAdi = "Kodlama.ip";
            musteri2.VergiNo = "12312312";

            Musteri musteri3 = new TuzelMusteri();
            Musteri musteri4 = new GercekMusteri();


        }
    }
}