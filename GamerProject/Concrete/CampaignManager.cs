using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GamerProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("%" + campaign.CampaignAmaount + " indirimli " + campaign.CampaignName + " adlı kampanya eklendi." );
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("%" + campaign.CampaignAmaount + " indirimli " + campaign.CampaignName + " adlı kampanya silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("%" + campaign.CampaignAmaount + " indirimli " + campaign.CampaignName + " adlı kampanya güncellendi.");
        }
    }
}
