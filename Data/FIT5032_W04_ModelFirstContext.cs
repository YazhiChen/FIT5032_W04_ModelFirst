using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FIT5032_W04_ModelFirst.Data
{
    public class FIT5032_W04_ModelFirstContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public FIT5032_W04_ModelFirstContext() : base("name=FIT5032_W04_ModelFirstContext")
        {
        }

        public System.Data.Entity.DbSet<FIT5032_W04_ModelFirst.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<FIT5032_W04_ModelFirst.Models.Unit> Units { get; set; }
    }
}
