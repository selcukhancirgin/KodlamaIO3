using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GamerProject.MernisServiceReference;

namespace GamerProject.Adapters
{
    public class MernisServiceAdapter : ICheckInformations
    {
        public bool Check(Gamer gamer)
        {
            
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            
            return client.TCKimlikNoDogrula(
                Convert.ToInt64(gamer.GamerNationalityID),
                                gamer.GamerFirstName.ToUpper(), 
                                gamer.GamerLastName.ToUpper(),
                                gamer.GamerBirthDate.Year
                );
        }
    }
}
