using System;

namespace structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen=new Dikdortgen();
            //dikdortgen.Uzunkenar=4;
            //dikdortgen.Kisakenar=3;
            Console.WriteLine("Class alan hesabı  :{0}",dikdortgen.AlanHesapla());

            Dikdortgen_struct dikdortgen_struct;
            dikdortgen_struct.Kisakenar=3;
            dikdortgen_struct.Uzunkenar=4;    
            
            Console.WriteLine("Class alan hesabı  :{0}",dikdortgen_struct.AlanHesapla());
        }
    }

    class Dikdortgen
    {
        public int Kisakenar;
        public int Uzunkenar;

      /*   public Dikdortgen()
        {
            Kisakenar=3;
            Uzunkenar=4;
        } */
        public long AlanHesapla() {
            return this.Kisakenar*this.Uzunkenar;
        }
    }

    struct Dikdortgen_struct
    {
        public int Kisakenar;
        public int Uzunkenar;
        public Dikdortgen_struct(int kisakenar, int uzunkenar)
        {
            
            Kisakenar = kisakenar;
            Uzunkenar = uzunkenar;
        }
        public long AlanHesapla() {
            return this.Kisakenar*this.Uzunkenar;
        }

    }
}
