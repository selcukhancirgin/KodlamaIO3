using GamerProject.Adapters;
using GamerProject.Concrete;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GamerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gm = new GamerManager(new MernisServiceAdapter());
            SaleManager sm = new SaleManager();
            CampaignManager cm = new CampaignManager();

            string ad, soyad, tc;
            DateTime date;

            Console.Write("Adınızı giriniz : ");
            ad = Console.ReadLine();
            Console.Write("Soyadınızı giriniz : ");
            soyad = Console.ReadLine();
            Console.Write("TC giriniz : ");
            tc = Console.ReadLine();
            Console.Write("Doğum tarihi giriniz : ");
            date = Convert.ToDateTime(Console.ReadLine());

            Gamer gamer = new Gamer();
            Game game = new Game();
            Campaign campaign = new Campaign();

            gamer.GamerBirthDate = date;
            gamer.GamerFirstName = ad;
            gamer.GamerLastName = soyad;
            gamer.GamerNationalityID = tc;
            game.GameName = "Valorant";
            game.GamePrice = 12000;
            campaign.CampaignAmaount = 5; //Yüzde olarak indirim uygulanmaktadır.
            campaign.CampaignName = "Bahar Kampanyası!";

            gm.Add(gamer);
            Console.WriteLine("\n");
            sm.List(game, gamer, campaign);
            Console.WriteLine("\n");
            cm.Add(campaign);
            cm.Delete(campaign);
            cm.Update(campaign);

            Console.ReadLine();


        }
    }
}
