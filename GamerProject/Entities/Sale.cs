using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GamerProject.Entities
{
    public class Sale 
    {
        //Veritabanı olmadıgı için burdaki kolonlara,propertylere değerleri eklememiz gereksiz.
        public string Gamer { get; set; }
        public string Game { get; set; }
        public double GamePrice { get; set; }
    }
}
