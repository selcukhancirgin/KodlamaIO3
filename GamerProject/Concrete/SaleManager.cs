using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GamerProject.Concrete
{
    public class SaleManager : ISaleService
    {
        //public void Delete(Game game, Gamer gamer)
        //{
        //    throw new NotImplementedException();
        //}

        public void List(Game game, Gamer gamer , Campaign campaign)
        {
            double discountAmaount = (game.GamePrice * campaign.CampaignAmaount) / 100;
            double newGameprice = game.GamePrice - discountAmaount;

            Console.WriteLine(
                "\n Ad Soyad : " +
                gamer.GamerFirstName + " " +
                gamer.GamerLastName + "\n Alınan Oyun : " +
                game.GameName + "\n Eski Fiyat : " +
                game.GamePrice.ToString() + "\n Yeni Fiyat : " +
                newGameprice.ToString() + "\n Kampanya Adı : " +
                campaign.CampaignName + "\n Kampanya Miktarı(%) : " +
                campaign.CampaignAmaount.ToString()
                );
        }

        //public void Update(Game game, Gamer gamer)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
