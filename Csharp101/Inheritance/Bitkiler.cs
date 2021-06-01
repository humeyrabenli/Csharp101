using System;

namespace Inheritance
{
    public class Bitkiler:Canlilar
    {
        protected void Fotosentez()
        {
            Console.WriteLine("Bitkisel fotosentez yapabilir");
        }
    }

    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler()
        {
            base.Fotosentez();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            
        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("tohumlu bitkiler tohumla cogalır");
        }

    }
    public class TohumsuzBitkiler:Bitkiler
    {
         public TohumsuzBitkiler()
        {
           
            base.Fotosentez();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            
        }
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla cogalir");
        }
    }
}