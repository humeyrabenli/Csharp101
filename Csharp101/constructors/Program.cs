using System;

namespace constructors
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
            Console.WriteLine("*****Çalışan 1*****");
            Calisan calisan1=new Calisan("Ayşe","Kara",2425242,"İnsan kaynakları");
            calisan1.CalisanBilgiler();
            Console.WriteLine("*******Çalışan 2********");

            Calisan calisan2=new Calisan();
            calisan2.Ad="Deniz";
            calisan2.Soyad="Arda";
            calisan2.No=24524756;
            calisan2.Departman="Satın Alma";

            calisan2.CalisanBilgiler();
            Console.WriteLine("*******Çalışan 3********");
            Calisan calisan3=new Calisan("Humeyra","Benli");
            calisan3.CalisanBilgiler();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        
        public Calisan(string ad,string soyad,int no,string departman) 
        {
            this.Ad=ad;
            this.Soyad=soyad;
            this.No=no;
            this.Departman=departman;
        }

        public Calisan(string ad,string soyad) 
        {
            this.Ad=ad;
            this.Soyad=soyad;
           
        }

        public Calisan(){

        }

        public void CalisanBilgiler()
        {
            Console.WriteLine("Çalışan Adı:{0}",Ad);
            Console.WriteLine("Çalışan Soyadı:{0}",Soyad);
            Console.WriteLine("Çalışan Numarası:{0}",No);
            Console.WriteLine("Çalışan Departmanı:{0}",Departman);
        }
    }
}
