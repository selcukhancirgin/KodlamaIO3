using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GamerProject.Abstract
{
    public interface ISaleService
    {
        void List(Game game, Gamer gamer , Campaign campaign);
        //void Delete(Game game, Gamer gamer);
        //void Update(Game game, Gamer gamer);
    }
}
