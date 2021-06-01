using System;

namespace Inheritance
{
    public class Canlilar
    {
        protected void Beslenme(){
            Console.WriteLine("Canlılar Beslenir");

        }
        protected void Solunum(){
            Console.WriteLine("Canlılar solunum yapar");

        }
        protected void Bosaltim(){
            Console.WriteLine("Canlılar Bosaltim yapar");
        }

        public virtual void UyaranlaraTepki() {
            Console.WriteLine("Canlılar uyaranlara tepki verir");
        }
         
    }
}