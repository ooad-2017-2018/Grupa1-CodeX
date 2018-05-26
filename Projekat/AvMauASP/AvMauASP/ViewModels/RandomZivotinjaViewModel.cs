using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using AvMauASP.Models;
using AvMauAzil.Models;

namespace AvMauASP.ViewModels
{
    public class RandomZivotinjaViewModel
    {
        public Zivotinja Zivotinja {get; set;}
       public List<Korisnik> Korisnici { get; set; }
    }
}