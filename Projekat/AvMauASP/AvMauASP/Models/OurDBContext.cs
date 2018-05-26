using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AvMauASP;
using AvMauAzil;

namespace AvMauASP.Models
{
    public class OurDBContext : DbContext
    {
        public DbSet<Korisnik> korisnik { get; set; }
    }
}