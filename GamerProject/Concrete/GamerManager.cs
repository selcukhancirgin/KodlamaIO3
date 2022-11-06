using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GamerProject.Concrete
{
    public class GamerManager : IGamerService
    {
        ICheckInformations _checkInformations;

        public GamerManager(ICheckInformations checkInformations)
        {
            _checkInformations = checkInformations;
        }

        public void Add(Gamer gamer)
        {
            if (_checkInformations.Check(gamer))
            {
                Console.WriteLine(gamer.GamerFirstName + " " + gamer.GamerLastName + " adlı oyuncu Eklendi \n");
            }
            else
            {
                Console.WriteLine("Bilgiler uyuşmadı\n");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer + " Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer + " Güncellendi");
        }
    }
}
