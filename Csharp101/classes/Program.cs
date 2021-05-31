using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erişim Belirleyiciler
            //*Public
            //*Private
            //*Internal
            //*Protected
            Calisan calisan1=new Calisan();
            calisan1.Ad="Ayşe";
            calisan1.Soyad="Kara";
            calisan1.No=2425242;
            calisan1.Departman="İnsan kaynakları";

            calisan1.CalisanBilgiler();
            Console.WriteLine("***************");

            Calisan calisan2=new Calisan();
            calisan2.Ad="Deniz";
            calisan2.Soyad="Arda";
            calisan2.No=24524756;
            calisan2.Departman="Satın Alma";

            calisan2.CalisanBilgiler();

        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgiler()
        {
            Console.WriteLine("Çalışan Adı:{0}",Ad);
            Console.WriteLine("Çalışan Soyadı:{0}",Soyad);
            Console.WriteLine("Çalışan Numarası:{0}",No);
            Console.WriteLine("Çalışan Departmanı:{0}",Departman);
        }
    }
}
