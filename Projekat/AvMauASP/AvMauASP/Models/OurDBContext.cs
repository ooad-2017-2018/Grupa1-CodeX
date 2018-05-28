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


        // private const string connectionStringName = "Name=avmauconnect1";

        // public OurDBContext() : base(connectionStringName) { }




        // protected override void OnModelCreating(DbModelBuilder modelBuilder)
        // {
        /*
        modelBuilder.Conventions.Add(
            new AttributeToColumnAnnotationConvention<TableColumnAttribute, string>(
                "ServiceColumnTable", (property, attributes) => attributes.Single().ColumnType.ToString()));
                */
        // }
    }
}