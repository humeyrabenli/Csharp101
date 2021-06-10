using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2_ToDo
{
    class CardManager
    {

        //Ana ekranda görünecek menu
        Process pr = new Process();

        //Kart ekleme
        public void AddCard()
        {
            var card = new Card();

            Console.WriteLine("Başlık Giriniz");
            card.Title = Console.ReadLine();

            Console.WriteLine("İçerik Giriniz");
            card.Content = Console.ReadLine();

            Console.WriteLine("Büyüklük Giriniz => XS(1), S(2), M(3), L(4), XL(5)");
            card.Size = (CardSize)int.Parse(Console.ReadLine());

            Console.WriteLine("Kişi ID'si Giriniz");
            int memberId = int.Parse(Console.ReadLine());

            Member result=MemberList.members.FirstOrDefault(x => x.Id == memberId);

            if (result==null)
            {
                Console.WriteLine("Girilen Numarada Kullanıcı Bulunamadı.");
                pr.Menu();
            }

            card.MemberID = memberId;
            Board.ToDo.Add(card);
            Console.WriteLine("Kart başarılı bir şekilde eklendi!");
            pr.Menu();

        }


        //Kart silme
        public void DeleteCard()
        {
            Console.WriteLine("Öncelikle Silmek İstediğiniz Kartı Seçmeniz Gerekiyor.");
            Console.WriteLine("Lütfen Kart Başlığını Yazınız.");
            string cardTitle = Console.ReadLine();


            int temp = 0;

            foreach (var item in Board.ToDo)
            {
                if (item.Title.ToLower() == cardTitle.ToLower())
                {
                    temp++;
                    Board.ToDo.Remove(item);
                    Console.WriteLine("SİLME İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                    break;
                }
            }
            foreach (var item in Board.InProgress)
            {
                if (item.Title.ToLower() == cardTitle.ToLower())
                {
                    temp++;
                    Board.InProgress.Remove(item);
                    Console.WriteLine("SİLME İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                    break;
                }
            }
            foreach (var item in Board.Done)
            {
                if (item.Title.ToLower() == cardTitle.ToLower())
                {
                    temp++;
                    Board.Done.Remove(item);
                    Console.WriteLine("SİLME İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                    break;
                }
            }

            if (temp == 0)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");

                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                }
                else if (choice == 2)
                {
                    DeleteCard();
                }
            }
        }

        //Listeleme
        public void BoardList()
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("************************");
            if (Board.ToDo.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var item in Board.ToDo)
                {
                    Console.WriteLine("Başlık      :{0}", item.Title);
                    Console.WriteLine("İçerik      :{0}", item.Content);
                    Console.WriteLine("Atanan Kişi :{0}", item.MemberID);
                    Console.WriteLine("Büyüklük    :{0}", item.Size);
                    Console.WriteLine("-");
                }
            }
            

            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************");
            if (Board.InProgress.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var item in Board.InProgress)
                {
                    Console.WriteLine("Başlık      :{0}", item.Title);
                    Console.WriteLine("İçerik      :{0}", item.Content);
                    Console.WriteLine("Atanan Kişi :{0}", item.MemberID);
                    Console.WriteLine("Büyüklük    :{0}", item.Size);
                    Console.WriteLine("-");
                }
            }
            Console.WriteLine();

            Console.WriteLine("DONE Line");
            Console.WriteLine("************************");
            if (Board.Done.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var item in Board.Done)
                {
                    Console.WriteLine("Başlık      :{0}", item.Title);
                    Console.WriteLine("İçerik      :{0}", item.Content);
                    Console.WriteLine("Atanan Kişi :{0}", item.MemberID);
                    Console.WriteLine("Büyüklük    :{0}", item.Size);
                    Console.WriteLine("-");
                }
            }

            pr.Menu();
        }


    
        //Kart taşıma
        public void CarryCard()
        {
            Console.WriteLine("Öncelikle güncellemek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            string cardTitle = Console.ReadLine();

            Console.WriteLine("Bulunan Kart Bilgileri: ");
            Console.WriteLine("**************************************");

            int value = 0;
            if (value == 0)
            {
                foreach (var item in Board.ToDo)
                {
                    if (item.Title.ToLower() == cardTitle.ToLower())
                    {
                        value++;
                        Console.WriteLine("Başlık      :{0}", item.Title);
                        Console.WriteLine("İçerik      :{0}", item.Content);
                        Console.WriteLine("Atanan Kişi :{0}", item.MemberID);
                        Console.WriteLine("Büyüklük    :{0}", item.Size);
                        Console.WriteLine("Line        :ToDo");

                        BoardLine();
                        int choice = int.Parse(Console.ReadLine());
                        if (choice == 1)
                        {
                        }
                        else if (choice == 2)
                        {
                            Board.InProgress.Add(item);
                            Board.ToDo.Remove(item);
                        }
                        else if (choice == 3)
                        {
                            Board.Done.Add(item);
                            Board.ToDo.Remove(item);
                        }
                        Console.WriteLine("TAŞIMA İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                        break;
                    }
                }
            }
            if (value == 0)
            {
                foreach (var item in Board.InProgress)
                {
                    if (item.Title.ToLower() == cardTitle.ToLower())
                    {
                        value++;
                        Console.WriteLine("Başlık      :{0}", item.Title);
                        Console.WriteLine("İçerik      :{0}", item.Content);
                        Console.WriteLine("Atanan Kişi :{0}", item.MemberID);
                        Console.WriteLine("Büyüklük    :{0}", item.Size);
                        Console.WriteLine("Line        :InProgress");

                        BoardLine();
                        int selected = int.Parse(Console.ReadLine());
                        if (selected == 1)
                        {
                            Board.ToDo.Add(item);
                            Board.InProgress.Remove(item);
                        }
                        else if (selected == 2)
                        {

                        }
                        else if (selected == 3)
                        {
                            Board.Done.Add(item);
                            Board.InProgress.Remove(item);
                        }
                        Console.WriteLine("TAŞIMA İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                        break;
                    }
                }
            }
            if (value == 0)
            {
                foreach (var item in Board.Done)
                {
                    if (item.Title.ToLower() == cardTitle.ToLower())
                    {
                        value++;
                        Console.WriteLine("Başlık      :{0}", item.Title);
                        Console.WriteLine("İçerik      :{0}", item.Content);
                        Console.WriteLine("Atanan Kişi :{0}", item.MemberID);
                        Console.WriteLine("Büyüklük    :{0}", item.Size);
                        Console.WriteLine("Line        :ToDo");

                        BoardLine();
                        int choice = int.Parse(Console.ReadLine());
                        if (choice == 1)
                        {
                            Board.ToDo.Add(item);
                            Board.Done.Remove(item);
                        }
                        else if (choice == 2)
                        {
                            Board.InProgress.Add(item);
                            Board.Done.Remove(item);
                        }
                        else if (choice == 3)
                        {
                        }
                        Console.WriteLine("TAŞIMA İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                        break;
                    }
                }
            }
        }

        public void BoardLine()
        {
            Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
            Console.WriteLine("(1) TODO");
            Console.WriteLine("(2) IN PROGRESS");
            Console.WriteLine("(3) DONE");
        }


    }
 }

