using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GamerProject.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
    }
}
