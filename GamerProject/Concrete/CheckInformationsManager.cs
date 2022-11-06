using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GamerProject.Concrete
{
    public class CheckInformationsManager : ICheckInformations
    {
        public bool Check(Gamer gamer)
        {
            return true;
        }
    }
}
