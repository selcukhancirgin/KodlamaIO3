﻿using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GamerProject.Abstract
{
    public interface ICheckInformations
    {
        bool Check(Gamer gamer);
    }
}
