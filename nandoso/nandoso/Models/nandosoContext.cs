using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace nandoso.Models
{

    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))] 

    public class nandosoContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public class MyConfiguration : DbMigrationsConfiguration<nandosoContext>
        {
            public MyConfiguration()
            {
                this.AutomaticMigrationsEnabled = true;
            }

            protected override void Seed(nandosoContext context)
            {
                var specials = new List<Specials>
            {
                new Specials {specialsID = 1011, productName = "Flame grilled chicken 1", price = 10.20, description = "This is our Flame grilled chicken 1"},
                new Specials {specialsID = 1021, productName = "Flame grilled chicken 2", price = 13.50, description = "This is our Flame grilled chicken 2"},
                new Specials {specialsID = 1042, productName = "Flame grilled chicken 3", price = 21.99, description = "This is our Flame grilled chicken 3"}
               
            };
                specials.ForEach(s => context.Specials.AddOrUpdate(p => p.productName, s));
                context.SaveChanges();
            }

        }




        public nandosoContext() : base("name=nandosoContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<nandosoContext, MyConfiguration>());
        }

        public System.Data.Entity.DbSet<nandoso.Models.Specials> Specials { get; set; }
    }
}
